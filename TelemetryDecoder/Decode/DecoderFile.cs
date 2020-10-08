using TelemetryDecoder.Helpers;
using System.IO;

namespace TelemetryDecoder.Decode
{
    sealed class DecoderFile : Decoder
    {
        private FileStream _fs; // Содержимое открытого .dat файла.

        public DecoderFile(string fileName, bool reedSoloFlag, bool nrzFlag)
        {
            _fileName = fileName;
            _isNrz = nrzFlag;
            _isReedSolo = reedSoloFlag;

            _jpeg = new Jpeg();

            _delegateCallCounter = 0;
            _logFilesNameCounter = 0;

            _fs = new FileStream(_fileName, FileMode.Open, FileAccess.Read);

            CreateLogDirectory();
            CreateNewLogFile(_logFilesNameCounter);

            StopDecoding = false;

            for (int i = 0; i < 6; i++)
            {
                _imagesLines[i] = new DirectBitmap(Constants.WDT, Constants.HGT);
            }
        }

        public override void StartDecode()
        {
            int bytesCount;

            do
            {
                bytesCount = _fs.Read(in_buf, 0, Constants.DL_IN_BUF);

                if (bytesCount < 2048)
                {
                    break;
                }

                beg_mark_uw = TestUw(bytesCount);
                _isInterliving = beg_mark_uw != -1;

                if (_isInterliving)
                {
                    Deinterl(); //деинтерливинг
                }
                else
                {
                    for (int i = 0; i < bytesCount; i += 2048)
                    {
                        ToBits(i);
                        ind_vit = _viterbi.DecodeViterbi(bits_buf, vit_buf);
                        FindTkIn();
                    }
                }

            } while (!StopDecoding);

            UpdateDataGui();
            FinishDecode();
        }
    }
}
