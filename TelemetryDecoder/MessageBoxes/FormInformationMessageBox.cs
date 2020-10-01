using MaterialSkin.Controls;
using TelemetryDecoder.Helpers;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace TelemetryDecoder.MessageBoxes
{
    /// <summary>
    /// MessageBox для информационных сообщений.
    /// </summary>
    public partial class FormInformationMessageBox : MaterialForm
    {
        private static FormInformationMessageBox _formInformationMessageBox;
        private static string _catalogPath;

        public FormInformationMessageBox()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Показать диалоговое окно.
        /// </summary>
        /// <param name="title">Заголовок окна.</param> 
        /// <param name="text">Содержимое текста сообщения.</param> 
        /// <param name="image">Изображение.</param> 
        /// <param name="text2">Содержимое текста сообщения (вторая строчка. необязательно).</param> 
        /// <param name="linkName">Содержимое текста ссылки (необязательно).</param> 
        /// <param name="catalogPath">Путь к каталогу текущего сеанса (необязательно).</param> 
        public static void Show(string title, string text, Bitmap image, string text2="", string linkName="", string catalogPath="")
        {         
            _formInformationMessageBox = new FormInformationMessageBox
            {
                Text = title,
                lblInfo = { Text = text },
                lblInfo2 = { Text = text2 },
                llPath = { Text = linkName },
                pbImage = { Image = image }
            };

            _catalogPath = catalogPath;

            RobotoFont.AllocFont(_formInformationMessageBox.llPath, 11);
            _formInformationMessageBox.llPath.LinkClicked += LinkClicked;

            _formInformationMessageBox.ShowDialog();
        }

        /// <summary>
        /// Нажатие на ссылку.
        /// </summary>
        /// <remarks>
        /// Открывает каталог текущего сеанса.
        /// </remarks>
        private static void LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(new ProcessStartInfo("explorer.exe", " /open, " + Path.GetDirectoryName(_catalogPath)));
        }
    }
}

