using System;
using System.Drawing;
using System.Windows.Forms;
using MaterialSkin.Controls;

namespace TelemetryDecoder.MessageBoxes
{
    /// <summary>
    /// Диалоговый MessageBox.
    /// </summary>
    public partial class FormDialogMessageBox : MaterialForm
    {
        private static FormDialogMessageBox _formDialogMessageBox;
        private static DialogResult _result = DialogResult.No;

        public FormDialogMessageBox()
        {
            InitializeComponent();
        }

        private void btnYes_Click(object sender, EventArgs e)
        {          
            _result = DialogResult.Yes;
            _formDialogMessageBox.Close();
        }

        /// <summary>
        /// Показать диалоговое окно.
        /// </summary>
        /// <param name="title">Заголовок окна.</param> 
        /// <param name="text">Содержимое текста сообщения.</param> 
        /// <param name="image">Изображение.</param> 
        /// <returns>
        /// Результат диалога.
        /// </returns>
        public static DialogResult Show(string title, string text, Bitmap image)
        {
            _result = DialogResult.No;

            _formDialogMessageBox = new FormDialogMessageBox
            {
                Text = title,
                lblMessage = { Text = text },
                pbPicture = { Image = image }
            };
            _formDialogMessageBox.ShowDialog();

            return _result;
        }
    }
}
