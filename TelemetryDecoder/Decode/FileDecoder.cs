using TelemetryDecoder.Helpers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelemetryDecoder.Decode
{
    sealed class FileDecoder : Decoder
    {
        /// <summary>
        /// Конструктор для открытого файла.
        /// </summary>
        /// <param name="fileName">Имя файла.</param>
        /// <param name="reedSoloFlag">Требуется ли декодирование Рида-Соломона.</param>
        /// <param name="nrzFlag">Есть ли NRZ.</param>
        public FileDecoder(string fileName, bool reedSoloFlag, bool nrzFlag)
        {
            _fileName = fileName;
            _isNrz = nrzFlag;
            _isReedSolo = reedSoloFlag;
          
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

        /// <summary>
        /// Начать декодирование для открытого файла.
        /// </summary>
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

                beg_mark_uw = FindSyncMark(bytesCount);
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
                        _counterVit = _viterbi.DecodeViterbi(bits_buf, vit_buf);
                        FindTkIn();
                    }
                }

            } while (!StopDecoding);

            UpdateDataGui();
            FinishDecode();
        }
    }
}
