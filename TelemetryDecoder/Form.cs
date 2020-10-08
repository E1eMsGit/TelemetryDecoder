using MaterialSkin.Controls;
using TelemetryDecoder.Helpers;
using TelemetryDecoder.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using TelemetryDecoder.MessageBoxes;
using TelemetryDecoder.Decode;

namespace TelemetryDecoder
{
    public partial class Form : MaterialForm
    {
        private string _fileName;
        private bool _isDecodeStarting;
        private bool _isFileOpened;
        
        private long _imageCounter; // Счетчик сохранненых изображений.

        private DecoderFile _fileDecoder;

        private Panel[] _allChannelsPanels = new Panel[6]; // Панели на которых находятся FLP для всех каналов.
        private Panel[] _channelsPanels = new Panel[6]; // Панели на которых находятся FLP для каждого канала.
        private FlowLayoutPanel[] _channels = new FlowLayoutPanel[6]; // FLP для хранения полосок изображения для каждого канала.
        private FlowLayoutPanel[] _allChannels = new FlowLayoutPanel[6]; // FLP для хранения полосок изображения для всех каналов.
        private List<Bitmap>[] _listImagesForSave = new List<Bitmap>[6]; // Список для хранения полосок изображения, нужно для сохранения.
      
        private DateTime _worktimestart; // Сколько времени ушло на декодирование (потом удалить).

        public Form()
        {
            RobotoFont.LoadFont();
            InitializeComponent();
        }

        private void FormDecode_Load(object sender, EventArgs e)
        {
            GuiUpdater.SmoothLoadingForm(this);

            GuiUpdater.DecodeRichTextBoxInit(rtbMkoTitle, rtbMkoData, rtbDateTimeTitle, rtbDateTime, rtbServiceTitle, rtbServiceData);

            materialTabControl1.SelectedTab = tabPage14;

            _isDecodeStarting = false;
            _isFileOpened = false;

            _channelsPanels[0] = pImage1;
            _channelsPanels[1] = pImage2;
            _channelsPanels[2] = pImage3;
            _channelsPanels[3] = pImage4;
            _channelsPanels[4] = pImage5;
            _channelsPanels[5] = pImage6;

            _allChannelsPanels[0] = pImage7;
            _allChannelsPanels[1] = pImage8;
            _allChannelsPanels[2] = pImage9;
            _allChannelsPanels[3] = pImage10;
            _allChannelsPanels[4] = pImage11;
            _allChannelsPanels[5] = pImage12;

            for (int i = 0; i < 6; i++)
            {
                _allChannels[i] = GuiUpdater.GetFlp(new Size(242, 8));
                _channels[i] = GuiUpdater.GetFlp(new Size(1556, 40));
                _allChannelsPanels[i].Controls.Add(_allChannels[i]);
                _channelsPanels[i].Controls.Add(_channels[i]);
                _listImagesForSave[i] = new List<Bitmap>();
            }

            slTime.Text = DateTime.Now.ToString(CultureInfo.CurrentCulture);
            timer1.Start();
        }     

        private void FormDecode_FormClosing(object sender, FormClosingEventArgs e)
        {
            var result = FormDialogMessageBox.Show("Выход", "Вы уверены, что хотите закрыть программу?", Resources.door_exit_icon);

            if (result != DialogResult.Yes)
            {
                e.Cancel = true;
            }
        }

        private void btnStartStopDecode_Click(object sender, EventArgs e)
        {
            StartStopDecoding();
        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog1 = new OpenFileDialog())
            {
                openFileDialog1.Title = "Выбор файла телеметрии";
                openFileDialog1.Filter = "Telemetry files (*.dat)|*.dat";
                openFileDialog1.FilterIndex = 1;

                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    _fileName = openFileDialog1.FileName;
                    lblFileName.Text = openFileDialog1.SafeFileName;
                    _isFileOpened = true;
                    lblFileName.ForeColor = Color.FromArgb(222, 0, 0, 0);
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            slTime.Text = DateTime.Now.ToString(CultureInfo.CurrentCulture);
        }

        private void bwImageSaver_DoWork(object sender, DoWorkEventArgs e)
        {
            ImageSaver.SaveImage(_listImagesForSave, _fileName, _imageCounter);
            _imageCounter += 1;
        }

        #region Начать/Остановить декодирование файла.

        /// <summary>
        /// Начать/Остановить декодирование файла.
        /// </summary> 
        /// <remarks>
        /// Создает декодер текущего сеанса.
        /// Очищает контролы от предыдущего сеанса.
        /// Проверяет выбран ли файл для декодирования.  
        /// </remarks>
        private async void StartStopDecoding()
        {
            if (_isFileOpened)
            {
                if (!_isDecodeStarting)
                {
                    bool reedSoloFlag = rbRSYes.Checked;
                    bool nrzFlag = rbNRZYes.Checked;
                    _imageCounter = 0;

                    _isDecodeStarting = true;
                    btnStartStopDecode.Text = "Остановить";

                    _fileDecoder = new DecoderFile(_fileName, reedSoloFlag, nrzFlag)
                    {
                        ThreadSafeUpdateGui = UpdateGuiDecodeData
                    };

                    // Очистка всего перед новым запуском.
                    for (int i = 0; i < 6; i++)
                    {
                        _allChannels[i].Controls.Clear();
                        _channels[i].Controls.Clear();
                        _listImagesForSave[i].Clear();
                        Directory.CreateDirectory($"{Path.GetDirectoryName(_fileName)}\\{Path.GetFileNameWithoutExtension(_fileName)}_Channel_{i + 1}");
                        DirectoryInfo di = new DirectoryInfo($"{Path.GetDirectoryName(_fileName)}\\{Path.GetFileNameWithoutExtension(_fileName)}_Channel_{i + 1}");

                        foreach (FileInfo file in di.GetFiles())
                        {
                            file.Delete();
                        }
                    }

                    tlpDecodingParameters.Enabled = false;

                    _worktimestart = DateTime.Now;
                 
                    await Task.Run(() => _fileDecoder.StartDecode());
                                           
                    StopDecoding();
                }
                else
                {
                    ForcedStopDecoding();
                }
            }
            else
            {
                lblFileName.ForeColor = GuiUpdater.ErrorColor;
            }
        }

        /// <summary>
        /// Принудительная остановка декодирования.
        /// </summary>
        /// <remarks>
        /// Нажатие на кнопку "Остановить".
        /// </remarks>
        private void ForcedStopDecoding()
        {
            _fileDecoder.StopDecoding = true;
        }

        /// <summary>
        /// Остановка декодирования.
        /// </summary> 
        /// <remarks>
        /// Логика остановки декодирования файла.
        /// </remarks>
        private void StopDecoding()
        {
            bwImageSaver.RunWorkerAsync();

            _isDecodeStarting = false;

            btnStartStopDecode.Text = "Начать";
            tlpDecodingParameters.Enabled = true;

            DateTime worktimefinish = DateTime.Now;
            TimeSpan deltaWorkingTime = worktimefinish - _worktimestart;

            slDecodeTime.Text = deltaWorkingTime.ToString();

            FormInformationMessageBox.Show("Сообщение", "Декодирование завершено.", Resources.done_icon, "Перейти в", "каталог с результатами", _fileName);
        }

        #endregion

        /// <summary>
        /// Обновление данных декодирования на GUI.
        /// </summary>
        /// <remarks>
        /// Связан с делегатом ThreadSafeUpdateGui в потоке декодирования.
        /// Каждые 60 вызовов этой функции вызывается сохранение полученных изображений.
        /// </remarks>
        /// <param name="linesDate">Значения Даты и времени полученной полосы.</param>
        /// <param name="linesService">Значения служебной информации полученной полосы.</param>
        /// <param name="linesTd">Значения ТД полученной полосы.</param>
        /// <param name="linesOshv">Значения ОШВ полученной полосы.</param>
        /// <param name="linesBshv">Значения БШВ полученной полосы.</param>
        /// <param name="linesPcdm">Значения ПЦДМ полученной полосы.</param>
        /// <param name="imagesLines">Полученные полосы изображений по каждому каналу.</param>
        private void UpdateGuiDecodeData(DateTime linesDate, string linesService, string linesTd, string linesOshv, string linesBshv, string linesPcdm, DirectBitmap[] imagesLines, int delegateCallCounter)
        {
            // Набрал 6400 строчек изображения (8 * 800).
            if (delegateCallCounter == Constants.DELEGATE_CALL_COUNTER)
            {
                bwImageSaver.RunWorkerAsync();
            }

            if (InvokeRequired)
            {
                Invoke(new Action(() => GuiUpdater.UpdateGuiDecodeData(linesService, linesTd, linesOshv, linesBshv, linesPcdm, linesDate,
                    rtbDateTime, rtbMkoData, rtbServiceData, _channels, _allChannels, _channelsPanels, _allChannelsPanels, _listImagesForSave, imagesLines)));
            }
        }
    }
}
