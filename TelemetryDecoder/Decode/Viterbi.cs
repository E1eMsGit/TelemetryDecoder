using System;

namespace TelemetryDecoder.Decode
{
    class Viterbi
    {
        private int[,] _mettab = new int[2,2]; // Metric table, [sent sym, rx symbol]
        private int[] _cMetric = new int[64];
        private int _gFirst;
        private int[] _mets = new int[4];
        private int[] _nMetric = new int[64];
        private int _mm0, _mm1;
        private int _decc;
        private int _bestState;
        private int[] _pths = new int[2 * Constants.PMEM];

        #region Конструктор.
        public Viterbi()
        {
            // метрики для витерби
            _mettab[0, 0] = 0;
            _mettab[0, 1] = -255;
            _mettab[1, 0] = -255;
            _mettab[1, 1] = 0;


            //Initialize starting metrics

            _cMetric[0] = 0;

            for (int i = 1; i < 64; i++)
                _cMetric[i] = -999999;

            _gFirst = 1;
        }
        
        #endregion

        #region Декодирование Витерби.
        public int DecodeViterbi(bool[] bits_buf, byte[] vit_buf)
        {
            ulong pk, pu;
            int ind;
            byte[] data = new byte[8];
            bool sym0, sym1;

            pk = 0;
            ind = 0;

            for (int indIn = 0; indIn < Constants.DL_IN_VIT_BUF; indIn += 4)
            {

                if (_cMetric[0] > 0x7fffffff - 10000)
                    for (int i = 0; i < 64; i++)
                        _cMetric[i] -= 32768;
                else
                    if (_cMetric[0] < -0x7fffffff + 10000)
                        for (int i = 0; i < 64; i++)
                            _cMetric[i] += -32768;

                //Read input symbol pair and compute branch metrics

                sym0 = bits_buf[indIn];
                sym1 = bits_buf[indIn + 1];
                
                _mets[0] = _mettab[0, Convert.ToInt32(sym1)] + _mettab[0, Convert.ToInt32(sym0)];
                _mets[3] = _mettab[1, Convert.ToInt32(sym1)] + _mettab[1, Convert.ToInt32(sym0)];
                _mets[1] = _mettab[0, Convert.ToInt32(sym1)] + _mettab[1, Convert.ToInt32(sym0)];
                _mets[2] = _mettab[1, Convert.ToInt32(sym1)] + _mettab[0, Convert.ToInt32(sym0)];                

                _decc = 0;

                Butterfly(0, 0);
                Butterfly(6, 0);
                Butterfly(8, 0);
                Butterfly(14, 0);
                Butterfly(2, 3);
                Butterfly(4, 3);
                Butterfly(10, 3);
                Butterfly(12, 3);
                Butterfly(1, 1);
                Butterfly(7, 1);
                Butterfly(9, 1);
                Butterfly(15, 1);
                Butterfly(3, 2);
                Butterfly(5, 2);
                Butterfly(11, 2);
                Butterfly(13, 2);

                _pths[2 * pk] = _decc;

                _decc = 0;
                Butterfly(19, 0);
                Butterfly(21, 0);
                Butterfly(27, 0);
                Butterfly(29, 0);
                Butterfly(17, 3);
                Butterfly(23, 3);
                Butterfly(25, 3);
                Butterfly(31, 3);
                Butterfly(18, 1);
                Butterfly(20, 1);
                Butterfly(26, 1);
                Butterfly(28, 1);
                Butterfly(16, 2);
                Butterfly(22, 2);
                Butterfly(24, 2);
                Butterfly(30, 2);

                _pths[2 * pk + 1] = _decc;
                pk++;

                // * Read input symbol pair and compute branch metrics * /

                sym0 = bits_buf[indIn + 2];
                sym1 = bits_buf[indIn + 3];

                _mets[0] = _mettab[0, Convert.ToInt32(sym1)] + _mettab[0, Convert.ToInt32(sym0)];
                _mets[3] = _mettab[1, Convert.ToInt32(sym1)] + _mettab[1, Convert.ToInt32(sym0)];
                _mets[1] = _mettab[0, Convert.ToInt32(sym1)] + _mettab[1, Convert.ToInt32(sym0)];
                _mets[2] = _mettab[1, Convert.ToInt32(sym1)] + _mettab[0, Convert.ToInt32(sym0)];

                _decc = 0;
                Butterfly2(0, 0);
                Butterfly2(6, 0);
                Butterfly2(8, 0);
                Butterfly2(14, 0);
                Butterfly2(2, 3);
                Butterfly2(4, 3);
                Butterfly2(10, 3);
                Butterfly2(12, 3);
                Butterfly2(1, 1);
                Butterfly2(7, 1);
                Butterfly2(9, 1);
                Butterfly2(15, 1);
                Butterfly2(3, 2);
                Butterfly2(5, 2);
                Butterfly2(11, 2);
                Butterfly2(13, 2);

                _pths[2 * pk] = _decc;

                _decc = 0;
                Butterfly2(19, 0);
                Butterfly2(21, 0);
                Butterfly2(27, 0);
                Butterfly2(29, 0);
                Butterfly2(17, 3);
                Butterfly2(23, 3);
                Butterfly2(25, 3);
                Butterfly2(31, 3);
                Butterfly2(18, 1);
                Butterfly2(20, 1);
                Butterfly2(26, 1);
                Butterfly2(28, 1);
                Butterfly2(16, 2);
                Butterfly2(22, 2);
                Butterfly2(24, 2);
                Butterfly2(30, 2);

                _pths[2 * pk + 1] = _decc;

                pk = (pk + 1) % Convert.ToUInt64(Constants.PMEM);

                if (Convert.ToBoolean(pk % 64)) continue;
                if (!Convert.ToBoolean(_gFirst))
                {
                    _bestState = 0;

                    pu = Convert.ToUInt64(Math.Abs(Convert.ToInt32((pk - 1) % Convert.ToUInt64(Constants.PMEM))));

                    for (int j = 0; j < 64 - 6; j++)
                    {
                        if (Convert.ToBoolean(Convert.ToInt32(_pths[2 * pu + Convert.ToUInt64(_bestState >> 5)]) & Convert.ToInt32(1 << (_bestState & 0x1f))))
                            _bestState |= 0x40; 

                        _bestState = _bestState >> 1;
                        pu = (pu - 1) % Convert.ToUInt64(Constants.PMEM);
                    }

                    for (int j = 7; j >= 0; j--)
                    {
                        data[j] = 0;
                        for (int i = 0; i < 8; i++)
                        {
                            if (Convert.ToBoolean(Convert.ToInt32(_pths[2 * pu + Convert.ToUInt64(_bestState >> 5)]) & Convert.ToInt32((1 << (_bestState & 0x1f)))))
                            {
                                _bestState |= 0x40;
                                data[j] |= Convert.ToByte(1 << i);
                            }

                            _bestState = _bestState >> 1;
                            pu = (pu - 1) % Convert.ToUInt64(Constants.PMEM);
                        }
                    }

                    for (int i = 0; i < 8; i++)
                        vit_buf[ind++] = data[i];
                }
                _gFirst = 0;
            }
            return ind;
        }

        #endregion

        private void Butterfly(int i, int sym)
        {
            //* ACS for 0 branch
            _mm0 = _cMetric[i] + _mets[sym]; //* 2*i
            _mm1 = _cMetric[i + 32] + _mets[3 ^ sym]; //* 2*i + 64
            _nMetric[2 * i] = _mm0;

            if (_mm1 > _mm0)
            {
                _nMetric[2 * i] = _mm1;
                _decc |= 1 << ((2 * i) & 0x1f);
            }

            //* ACS for 1 branch
            _mm0 -= (_mets[sym] - _mets[3 ^ sym]);
            _mm1 += (_mets[sym] - _mets[3 ^ sym]);
            _nMetric[2 * i + 1] = _mm0;

            if (_mm1 > _mm0)
            {
                _nMetric[2 * i + 1] = _mm1;
                _decc |= 1 << ((2 * i + 1) & 0x1f);
            }
        }

        private void Butterfly2(int i, int sym)
        {
            //* ACS for 0 branch
            _mm0 = _nMetric[i] + _mets[sym]; //* 2*i
            _mm1 = _nMetric[i + 32] + _mets[3 ^ sym]; //* 2*i + 64
            _cMetric[2 * i] = _mm0;

            if (_mm1 > _mm0)
            {
                _cMetric[2 * i] = _mm1;
                _decc |= 1 << ((2 * i) & 0x1f);
            }

            //* ACS for 1 branch
            _mm0 -= _mets[sym] - _mets[3 ^ sym];
            _mm1 += _mets[sym] - _mets[3 ^ sym];
            _cMetric[2 * i + 1] = _mm0;

            if (_mm1 > _mm0)
            {
                _cMetric[2 * i + 1] = _mm1;
                _decc |= 1 << ((2 * i + 1) & 0x1f);
            }
        }
    }
}
