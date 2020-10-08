using System;
using TelemetryDecoder.Helpers;

namespace TelemetryDecoder.Decode
{
    class Jpeg
    {
        public int[] video_mass = new int[Constants.DL_VIDEO]; //Буфер видео - пикселы, после декомпроессии jpeg
        public byte[] jpeg_buf_in = new byte[Constants.DL_JPEG]; //Буфер jpeg с шапкой.

        private int _dl_jpeg_in;
        private int ind_jpeg_in;    //индекс и кол-во на выдачу
        private byte _Q_Value; // Фактор качества.

        private struct DC_TABLE
        {
            public int L;
            public int V;
        };

        private DC_TABLE[] DC_HUF = new DC_TABLE[16];
        private DC_TABLE[,] AC_HUF = new DC_TABLE[16, 11];

        private static uint[] DC_L = { 0, 0, 1, 5, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0 };
        private static uint[] DC_V = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 0xA, 0xB, 0, 0, 0, 0, 0 };
        private static uint[] AC_L = { 0, 0, 2, 1, 3, 3, 2, 4, 3, 5, 5, 4, 4, 0, 0, 1, 0x7D };
        private static uint[] AC_I = { 0x01, 0x02, 0x03, 0x00, 0x04, 0x11, 0x05, 0x12,0x21, 0x31, 0x41, 0x06,
            0x13, 0x51, 0x61, 0x07, 0x22, 0x71, 0x14, 0x32, 0x81, 0x91, 0xA1, 0x08, 0x23, 0x42, 0xB1, 0xC1,
            0x15, 0x52, 0xD1, 0xF0, 0x24, 0x33, 0x62, 0x72, 0x82, 0x09, 0x0A, 0x16, 0x17, 0x18, 0x19, 0x1A,
            0x25, 0x26, 0x27, 0x28, 0x29, 0x2A, 0x34, 0x35, 0x36, 0x37, 0x38, 0x39, 0x3A, 0x43, 0x44, 0x45,
            0x46, 0x47, 0x48, 0x49, 0x4A, 0x53, 0x54, 0x55, 0x56, 0x57, 0x58, 0x59, 0x5A, 0x63, 0x64, 0x65,
            0x66, 0x67, 0x68, 0x69, 0x6A, 0x73, 0x74, 0x75, 0x76, 0x77, 0x78, 0x79, 0x7A, 0x83, 0x84, 0x85,
            0x86, 0x87, 0x88, 0x89, 0x8A, 0x92, 0x93, 0x94, 0x95, 0x96, 0x97, 0x98, 0x99, 0x9A, 0xA2, 0xA3,
            0xA4, 0xA5, 0xA6, 0xA7, 0xA8, 0xA9, 0xAA, 0xB2, 0xB3, 0xB4, 0xB5, 0xB6, 0xB7, 0xB8, 0xB9, 0xBA,
            0xC2, 0xC3, 0xC4, 0xC5, 0xC6, 0xC7, 0xC8, 0xC9, 0xCA, 0xD2, 0xD3, 0xD4, 0xD5, 0xD6, 0xD7, 0xD8,
            0xD9, 0xDA, 0xE1, 0xE2, 0xE3, 0xE4, 0xE5, 0xE6, 0xE7, 0xE8, 0xE9, 0xEA, 0xF1, 0xF2, 0xF3, 0xF4,
            0xF5, 0xF6, 0xF7, 0xF8, 0xF9, 0xFA };
        private static short[] QT_C = { 16, 11, 10, 16, 24, 40, 51, 61, 12, 12, 14, 19, 26, 58, 60, 55, 14, 13,
            16, 24, 40, 57, 69, 56, 14, 17, 22, 29, 51, 87, 80, 62, 18, 22, 37, 56, 68, 109, 103, 77, 24, 35, 55,
            64, 81,104,113, 92, 49, 64, 78, 87, 103, 121, 120, 101, 72, 92, 95, 98, 112, 100, 103, 99 };
        private static byte[,] ZigzagToTable = {
            {0, 1, 5, 6, 14, 15, 27, 28},
            {2, 4, 7, 13, 16, 26, 29, 42},
            {3, 8, 12, 17, 25, 30, 41, 43},
            {9, 11, 18, 24, 31, 40, 44, 53},
            {10, 19, 23, 32, 39, 45, 52, 54},
            {20, 22, 33, 38, 46, 51, 55, 60},
            {21, 34, 37, 47, 50, 56, 59, 61},
            {35, 36, 48, 49, 57, 58, 62, 63}

        };

        private int[,] QUANT = new int[8, 8];
        private float[,] DCT = new float[8, 8];
        private float[,] DCT_T = new float[8, 8];
        private short[] DATA = new short[64];

        private byte _curByte;

        private int[,] RES_QVANT = new int[8, 8];
        private int[,] RES_DEQVANT = new int[8, 8];
        private float[,] JPG = new float[8, 8];
        private float[,] JPG1 = new float[8, 8];

        private int CurBit;

        public Jpeg()
        {
            FillTables();
            FillDctMatrix();
        }

        public int DeCompress(int x, int dl_jpeg_in, byte Q_Value)
        {
            int k, Number;
            int PDIFF;
            int Row;
            int Run, Size, Col;
            int indv;

            _dl_jpeg_in = dl_jpeg_in;
            _Q_Value = Q_Value;
            ind_jpeg_in = 20 - 1;   //индекс на выдачу с учетом шапки
            CurBit = 0;
            _curByte = 0;

            PDIFF = 0;

            indv = 0;

            if (_Q_Value <= 0)
            {
                return 0;
            }

            FillQuant();

            while (ind_jpeg_in < _dl_jpeg_in)
            {
                Row = HuffmanCodeOfDC();

                Col = ReadBits(Row);

                for (int i = 0; i < 64; i++)
                {
                    DATA[i] = 0;
                }

                DATA[0] = Convert.ToInt16(BitsToInteger(Row, Col) + PDIFF);
                PDIFF = DATA[0];

                k = 1;

                do
                {
                    HuffmanCodeOfAC(out Run, out Size);

                    if (!Convert.ToBoolean(Run) && !Convert.ToBoolean(Size))
                    {
                        break;
                    }

                    Col = ReadBits(Size);

                    if (k + Run < 64)
                    {
                        DATA[k + Run] = Convert.ToInt16(BitsToInteger(Size, Col));
                    }

                    k = k + 1 + Run;

                } while (k < 64);

                for (int i = 0; i < 8; i++)
                    for (int j = 0; j < 8; j++)
                        RES_QVANT[i, j] = DATA[ZigzagToTable[i, j]];

                DeQuantization();
                IDCTMatrix();

                for (int i = 0; i < 8; i++)
                {
                    for (int j = 0; j < 8; j++)
                    {
                        Number = (int)(JPG[i, j] + 0.5);

                        if (Number > 255)
                        {
                            Number = 255;
                        }
                        else if (Number < 0)
                        {
                            Number = 0;
                        }

                        video_mass[indv++] = Number; //кубик 8x8: по 8 по горизонтали, потом по верт.
                        if (indv == Constants.DL_VIDEO)
                            return indv;
                    }
                }
            }

            return indv;
        }

        private void FillTables()
        {
            int cat, k, x, y;
            uint w;

            // Fill Table of DC
            cat = 0; k = 0; w = 0;

            for (int i = 0; i < 16; i++)
            {
                DC_HUF[i].L = 0;
                DC_HUF[i].V = 0;
            }

            //cat-category
            for (int i = 0; i < 16; i++)
            {
                for (uint j = 0; j < DC_L[i]; j++)
                {
                    DC_HUF[cat].L = Convert.ToInt32(DC_V[k]);    //code length
                    DC_HUF[cat].V = Convert.ToInt32(w);      //code word
                    w++;
                    cat++;

                    if (cat > 15)
                    {
                        break;
                    }
                }

                w = w << 1;
                k++;
            }

            k = 0; w = 0;
            for (int i = 0; i < 17; i++)
            {
                for (uint j = 0; j < AC_L[i]; j++)
                {
                    x = Convert.ToInt32((AC_I[k] & 0xF0) >> 4);
                    y = Convert.ToInt32(AC_I[k] & 0xF);
                    AC_HUF[x, y].L = i; //code length
                    AC_HUF[x, y].V = Convert.ToInt32(w); //code word
                    w++;
                    k++;
                }
                w = w << 1;
            }
        }

        private void FillDctMatrix()
        {
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if (!Convert.ToBoolean(i))
                    {
                        DCT[i, j] = Convert.ToSingle(1 / Math.Sqrt(8));
                    }
                    else
                    {
                        DCT[i, j] = Convert.ToSingle(Math.Cos((2 * j + 1) * i * Math.PI / 16) / 2);
                    }
                }
            }

            for (int i = 0; i < 8; i++)
                for (int j = 0; j < 8; j++)
                    DCT_T[i, j] = DCT[j, i];
        }

        private void FillQuant()
        {
            int kq;
            float fs;

            if (_Q_Value <= 50)
            {
                fs = Convert.ToSingle(5000 / _Q_Value);
            }
            else
            {
                fs = 200 - 2 * _Q_Value;
            }


            kq = 0;
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    QUANT[i, j] = Convert.ToInt32(QT_C[kq] * fs / 100);
                    if (QUANT[i, j] < 1)
                    {
                        QUANT[i, j] = 1;
                    }
                    kq++;
                }
            }
        }

        private int BitsToInteger(int Bits, int Value)
        {
            if ((Value & (1 << (Bits - 1))) > 0)
            {
                return Value;
            }

            return -(Value ^ ((1 << Bits) - 1));
        }

        /// <summary>
        /// Find Huffman Code from bitstream.
        /// </summary>
        private int HuffmanCodeOfDC()
        {
            int v, L;

            L = 0;
            v = 0;

            do
            {
                L++;
                AddNextBit(ref v);

                for (int i = 0; i < 16; i++)
                {
                    if (DC_HUF[i].L == L && DC_HUF[i].V == v)

                    {
                        return i;
                    }
                }
            } while (L < 16);

            return 0;
        }

        /// <summary>
        /// Чтение очередного бита.
        /// </summary>
        private void AddNextBit(ref int v)
        {
            byte b;

            if (!Convert.ToBoolean(CurBit))
            {
                ind_jpeg_in++;

                _curByte = ind_jpeg_in == _dl_jpeg_in ? (byte)0 : jpeg_buf_in[ind_jpeg_in];
            }

            b = Convert.ToByte((_curByte >> (7 - CurBit)) & 0x01);

            CurBit++;

            if (CurBit == 8)
            {
                CurBit = 0;
            }

            v = (v << 1) | b;
        }

        private int ReadBits(int bits)
        {
            int l;

            l = 0;

            for (int i = 0; i < bits; i++)
            {
                AddNextBit(ref l);
            }

            return l;
        }

        private void HuffmanCodeOfAC(out int Run, out int Size)
        {
            int L;
            int v;

            L = 0;
            v = 0;

            do
            {
                L++;
                AddNextBit(ref v);

                for (int i = 0; i < 16; i++)
                {
                    for (int j = 0; j < 11; j++)
                    {
                        if (AC_HUF[i, j].L == L && AC_HUF[i, j].V == v)
                        {
                            Run = i;
                            Size = j;
                            return;
                        }
                    }
                }
            } while (L < 16);

            Run = 0;
            Size = 0;
        }

        private void DeQuantization()
        {
            for (int j = 0; j < 8; j++)
                for (int i = 0; i < 8; i++)
                    RES_DEQVANT[i, j] = RES_QVANT[i, j] * QUANT[i, j];

        }

        private void IDCTMatrix()
        {
            for (int j = 0; j < 8; j++)
            {
                for (int i = 0; i < 8; i++)
                {
                    JPG1[i, j] = 0;
                    JPG1[i, j] += DCT_T[i, 0] * RES_DEQVANT[0, j];
                    JPG1[i, j] += DCT_T[i, 1] * RES_DEQVANT[1, j];
                    JPG1[i, j] += DCT_T[i, 2] * RES_DEQVANT[2, j];
                    JPG1[i, j] += DCT_T[i, 3] * RES_DEQVANT[3, j];
                    JPG1[i, j] += DCT_T[i, 4] * RES_DEQVANT[4, j];
                    JPG1[i, j] += DCT_T[i, 5] * RES_DEQVANT[5, j];
                    JPG1[i, j] += DCT_T[i, 6] * RES_DEQVANT[6, j];
                    JPG1[i, j] += DCT_T[i, 7] * RES_DEQVANT[7, j];
                }
            }

            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    JPG[i, j] = 0;
                    JPG[i, j] += JPG1[i, 0] * DCT[0, j];
                    JPG[i, j] += JPG1[i, 1] * DCT[1, j];
                    JPG[i, j] += JPG1[i, 2] * DCT[2, j];
                    JPG[i, j] += JPG1[i, 3] * DCT[3, j];
                    JPG[i, j] += JPG1[i, 4] * DCT[4, j];
                    JPG[i, j] += JPG1[i, 5] * DCT[5, j];
                    JPG[i, j] += JPG1[i, 6] * DCT[6, j];
                    JPG[i, j] += JPG1[i, 7] * DCT[7, j];

                    JPG[i, j] += 128;

                    if (JPG[i, j] < 0)
                    {
                        JPG[i, j] = 0;
                    }
                }
            }
        }
    }
}