using TelemetryDecoder.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TelemetryDecoder.Helpers
{
    /// <summary>
    /// Класс для работы со шрифтом из ресурсов приложения.
    /// </summary>
    static class RobotoFont
    {
        [DllImport("gdi32.dll")]
        private static extern IntPtr AddFontMemResourceEx(IntPtr pbfont, uint cbfont, IntPtr pdv, [In] ref uint pcFonts);
        private static FontFamily _ff;

        /// <summary>
        /// Загрузка шрифта из ресурсов.
        /// </summary>
        /// <remarks>
        /// Вызвал при загрузке главного меню.
        /// </remarks>
        public static void LoadFont()
        {
            byte[] fontArray = Resources.Roboto_Regular;
            int dataLength = Resources.Roboto_Regular.Length;

            IntPtr ptrData = Marshal.AllocCoTaskMem(dataLength);
            Marshal.Copy(fontArray, 0, ptrData, dataLength);

            uint cFonts = 0;

            AddFontMemResourceEx(ptrData, (uint)fontArray.Length, IntPtr.Zero, ref cFonts);

            PrivateFontCollection pfc = new PrivateFontCollection();
            pfc.AddMemoryFont(ptrData, dataLength);
            Marshal.FreeCoTaskMem(ptrData);
            _ff = pfc.Families[0];
        }

        /// <summary>
        /// Применение шрифта к контролу.
        /// </summary>
        /// <param name="control">Контрол к которому нужно применить шрифт.</param> 
        /// <param name="size">Размер шрифта.</param> 
        public static void AllocFont(Control control, float size)
        {
            FontStyle fontStyle = FontStyle.Regular;
            control.Font = new Font(_ff, size, fontStyle);
        }
    }
}
