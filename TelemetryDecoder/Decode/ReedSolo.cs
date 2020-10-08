using System;

namespace TelemetryDecoder.Decode
{
    class ReedSolo
    {
        private byte[] C_GF = new byte[256]; // преобразование произвольного байта в элемент поля Галуа
        public byte[] Rdx = new byte[1020]; // псевдошумовая последовательность для рандомизации
        private byte[] u1 = new byte[255]; //результат кодировани(исх вектора + пров. символы)       

        private static byte[] GF_elem = {
            0x01,0x02,0x04,0x08,0x10,0x20,0x40,0x80,0x87,0x89,0x95,0xad,0xdd,0x3d,0x7a,
            0xf4,0x6f,0xde,0x3b,0x76,0xec,0x5f,0xbe,0xfb,0x71,0xe2,0x43,0x86,0x8b,0x91,0xa5,
            0xcd,0x1d,0x3a,0x74,0xe8,0x57,0xae,0xdb,0x31,0x62,0xc4,0x0f,0x1e,0x3c,0x78,0xf0,
            0x67,0xce,0x1b,0x36,0x6c,0xd8,0x37,0x6e,0xdc,0x3f,0x7e,0xfc,0x7f,0xfe,0x7b,0xf6,
            0x6b,0xd6,0x2b,0x56,0xac,0xdf,0x39,0x72,0xe4,0x4f,0x9e,0xbb,0xf1,0x65,0xca,0x13,
            0x26,0x4c,0x98,0xb7,0xe9,0x55,0xaa,0xd3,0x21,0x42,0x84,0x8f,0x99,0xb5,0xed,0x5d,
            0xba,0xf3,0x61,0xc2,0x03,0x06,0x0c,0x18,0x30,0x60,0xc0,0x07,0x0e,0x1c,0x38,0x70,
            0xe0,0x47,0x8e,0x9b,0xb1,0xe5,0x4d,0x9a,0xb3,0xe1,0x45,0x8a,0x93,0xa1,0xc5,0x0d,
            0x1a,0x34,0x68,0xd0,0x27,0x4e,0x9c,0xbf,0xf9,0x75,0xea,0x53,0xa6,0xcb,0x11,0x22,
            0x44,0x88,0x97,0xa9,0xd5,0x2d,0x5a,0xb4,0xef,0x59,0xb2,0xe3,0x41,0x82,0x83,0x81,
            0x85,0x8d,0x9d,0xbd,0xfd,0x7d,0xfa,0x73,0xe6,0x4b,0x96,0xab,0xd1,0x25,0x4a,0x94,
            0xaf,0xd9,0x35,0x6a,0xd4,0x2f,0x5e,0xbc,0xff,0x79,0xf2,0x63,0xc6,0x0b,0x16,0x2c,
            0x58,0xb0,0xe7,0x49,0x92,0xa3,0xc1,0x05,0x0a,0x14,0x28,0x50,0xa0,0xc7,0x09,0x12,
            0x24,0x48,0x90,0xa7,0xc9,0x15,0x2a,0x54,0xa8,0xd7,0x29,0x52,0xa4,0xcf,0x19,0x32,
            0x64,0xc8,0x17,0x2e,0x5c,0xb8,0xf7,0x69,0xd2,0x23,0x46,0x8c,0x9f,0xb9,0xf5,0x6d,
            0xda,0x33,0x66,0xcc,0x1f,0x3e,0x7c,0xf8,0x77,0xee,0x5b,0xb6,0xeb,0x51,0xa2,0xc3,
            0x00 }; // множество всех элементов поля Галуа

        private byte[] err_pos = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        private byte[] err_mas = { 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255 };

        private byte[] S = new byte[32];
        private byte[,] SM = new byte[16, 16];
        private byte[,] SSM = new byte[16, 16];
        private byte[,] SSM1 = new byte[16, 16];

        private byte[] SIG = new byte[17];
        private byte[] SS = new byte[16];
        private byte[] ER = new byte[255];
        private byte[] SV = new byte[32];

        public ReedSolo()
        {
            form_C_GF();
            form_SV();
            form_Rdx();
        }

        public void Decode_RS(byte[] incomingTransportFrame, bool isReedSolo)
        {
            int z;
            int d, d1, n, j, m;
            uint gErr1 = 0, gErr2 = 0;

            for (int i = 0; i < 1020; i++)
            {
                incomingTransportFrame[i] ^= Rdx[i];
            }

            if (!isReedSolo)
            {
                return;
            }

            for (m = 0; m < 4; m++)
            {

                for (int i = 0; i < 16; i++)
                {
                    err_mas[i] = 255;
                }

                for (int i = 0; i < 255; i++)
                {
                    u1[i] = C_GF[incomingTransportFrame[i * 4 + m]];
                }

                form_S();
                z = 0;

                for (int i = 0; i < 32; i++)
                {
                    if (S[i] == 255)
                    {
                        z++;
                    }
                }

                if (z < 32)
                {
                    gErr1++;       //считаем ошибки

                    d = 255;
                    n = 16;

                    while (d == 255 && n > 0)
                    {
                        form_SM_SS(n);
                        d = inv_SM(n);
                        n--;
                    }

                    n++;

                    for (int i = 0; i < n; i++)
                    {
                        d = 255;

                        for (j = 0; j < n; j++)
                        {
                            d1 = mp2(SSM[i, j], SS[j]);
                            d = sm2(d, d1);
                        }

                        SIG[i] = Convert.ToByte(d);
                    }

                    for (int i = n; i < 17; i++)
                    {
                        SIG[i] = 0;
                    }

                    check_SIG(n);

                    j = 0;
                    for (int i = 0; i < 255 && j < n; i++)
                    {
                        if (ER[i] == 255)
                        {
                            err_pos[j] = Convert.ToByte(255 - i);
                            j++;
                        }
                    }

                    form_BM_SS(n);
                    d = inv_SM(n);

                    z = 0;

                    for (int i = 0; i < j; i++)
                    {
                        if (err_pos[i] != 255)
                        {
                            z++;
                        }
                    }

                    if (n == z)
                    {
                        gErr2++;
                    }

                    if (d != 255)
                    {
                        for (int i = 0; i < n; i++)
                        {
                            d = 255;

                            for (j = 0; j < n; j++)
                            {
                                d1 = mp2(SSM[i, j], SS[j]);
                                d = sm2(d, d1);
                            }

                            err_mas[i] = Convert.ToByte(d);

                            if (err_pos[i] != 255)
                            {
                                u1[255 - err_pos[i] - 1] = Convert.ToByte(sm2(u1[255 - err_pos[i] - 1], d));
                            }
                        }
                    }
                }

                for (int i = 0; i < 255; i++)
                {
                    incomingTransportFrame[i * 4 + m] = GF_elem[u1[i]];
                }
            }
        }

        /// <summary>
        /// Сложение.
        /// </summary>
        private int sm2(int d1, int d2)
        {
            if (d1 > 255 || d2 > 255 || d1 < 0 || d2 < 0)
                return -1;

            d1 = GF_elem[d1];
            d2 = GF_elem[d2];

            return C_GF[d1 ^ d2];
        }

        /// <summary>
        /// Умножение.
        /// </summary>
        private int mp2(int d1, int d2)
        {
            int d;

            if (d1 == 255 || d2 == 255)
                return 255;

            d = d1 + d2;

            if (d > 254)
                d -= 255;

            return d;
        }

        /// <summary>
        /// Степень.
        /// </summary>
        private int pw2(int x, int n)
        {
            if (x == 255)
                return 255;

            return x * n % 255;
        }

        /// <summary>
        /// Формирование преобразования произвольного байта в элемент поля Галуа.
        /// </summary>
        private void form_C_GF()
        {
            for (int i = 0; i < 256; i++)
            {
                int j = GF_elem[i];
                C_GF[j] = Convert.ToByte(i);
            }
        }

        private void form_SV()
        {
            for (int i = 0; i < 32; i++)
            {
                SV[i] = Convert.ToByte(11 * (112 + i) % 255);
            }
        }

        /// <summary>
        /// Формирование псевдошумовой последовательности.
        /// </summary>
        private void form_Rdx()
        {
            int c, d, c1;
            int a = 0xff;

            for (int i = 0; i < 255; i++)
            {
                c = 0x00;
                for (int j = 0; j < 8; j++)
                {
                    c1 = (a & 0x01) << (7 - j);
                    c = c1 | c;
                    d = ((a & 0x01) + ((a & 0x08) >> 3)) % 2;
                    d = (((a & 0x20) >> 5) + d) % 2;
                    d = (((a & 0x80) >> 7) + d) % 2;
                    a = (d << 7) | (a >> 1);
                }

                Rdx[i] = Convert.ToByte(c);
                Rdx[i + 255] = Convert.ToByte(c);
                Rdx[i + 510] = Convert.ToByte(c);
                Rdx[i + 765] = Convert.ToByte(c);
            }
        }

        private void form_S()
        {
            int t, n, m;

            for (int j = 0; j < 32; j++)
            {
                t = 255;
                for (int i = 0; i < 255; i++)
                {
                    n = pw2(SV[j], 254 - i);
                    m = mp2(u1[i], n);
                    t = sm2(t, m);
                }
                S[j] = Convert.ToByte(t);
            }
        }

        private void form_SM_SS(int n)
        {
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                    SM[i, j] = S[i + j];

            for (int i = 0; i < n; i++)
                SS[i] = S[n + i];

            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                    SSM[i, j] = SM[i, j];
        }

        private void form_BM_SS(int n)
        {
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                    SM[i, j] = Convert.ToByte(pw2(err_pos[j], (i + 112) * 11 % 255));

            for (int i = 0; i < n; i++)
                SS[i] = S[i];

            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                    SSM[i, j] = SM[i, j];
        }

        private int inv_SM(int n)
        {
            int d, det, D;

            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                    SSM[i, j] = SM[i, j];

            det = find_det(n);

            if (det != 255)
            {
                form_Adop(n);

                D = 255 - det;

                for (int i = 0; i < n; i++)
                    for (int j = 0; j < n; j++)
                        SSM[i, j] = Convert.ToByte(mp2(SSM1[i, j], D));

                // в SSM1 результат произведения исходной матрицы и кофактора
                // дла проверки правильности нахождения кофактора
                // __ можно убрать
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        SSM1[i, j] = 255;

                        for (int k = 0; k < n; k++)
                        {
                            d = mp2(SM[i, k], SSM[k, j]);
                            SSM1[i, j] = Convert.ToByte(sm2(SSM1[i, j], d));
                        }
                    }
                }
            }
            return det;
        }

        private void form_Adop(int n)
        {
            int d;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    form_det(i, j, n);
                    SSM1[i, j] = Convert.ToByte(find_det(n - 1));
                }
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    d = SSM1[i, j];
                    SSM1[i, j] = SSM1[j, i];
                    SSM1[j, i] = Convert.ToByte(d);
                }
            }
        }

        private void form_det(int i1, int j1, int n)
        {
            for (int i = 0; i < i1; i++)
                for (int j = 0; j < n; j++)
                    SSM[i, j] = SM[i, j];

            for (int i = i1 + 1; i < n; i++)
                for (int j = 0; j < n; j++)
                    SSM[i - 1, j] = SM[i, j];

            for (int j = j1 + 1; j < n; j++)
                for (int i = 0; i < n; i++)
                    SSM[i, j - 1] = SSM[i, j];


            for (int i = 0; i < n; i++)
            {
                SSM[i, n - 1] = 255;
                SSM[n - 1, i] = 255;
            }
        }

        private void check_SIG(int n)
        {
            int t, z, m;

            for (int j = 0; j < 255; j++)
            {
                t = 255;
                for (int i = 0; i < n + 1; i++)
                {
                    z = pw2(j * 11 % 255, n + 1 - i);
                    m = mp2(SIG[i], z);
                    t = sm2(t, m);
                }
                ER[j] = Convert.ToByte(t);
            }
        }

        private int find_det(int n)
        {
            int i, t = 0, d, d1, d2, d3, Det = 0;

            while (t < n - 1)
            {
                i = t;

                while (i < n && SSM[i, t] == 255)
                {
                    i++;
                }

                if (i < n)
                {
                    for (int k = 0; k < n; k++)
                    {
                        d = SSM[i, k];
                        SSM[i, k] = SSM[t, k];
                        SSM[t, k] = Convert.ToByte(d);
                    }
                }

                for (i = t + 1; i < n; i++)
                {
                    d = SSM[i, t];
                    d3 = SSM[t, t];

                    if (d != 255)
                    {
                        if (d3 > 0)
                        {
                            Det = mp2(Det, 255 - d3);
                        }

                        for (int j = t; j < n; j++)
                        {
                            d1 = mp2(SSM[t, j], d);
                            d2 = mp2(SSM[i, j], d3);
                            SSM[i, j] = Convert.ToByte(sm2(d1, d2));
                        }
                    }
                }
                t++;
            }

            for (i = 0; i < n; i++)
            {
                Det = mp2(SSM[i, i], Det);
            }

            return Det;
        }
    }
}
