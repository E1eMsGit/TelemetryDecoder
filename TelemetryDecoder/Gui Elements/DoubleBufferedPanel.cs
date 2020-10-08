using System.Windows.Forms;

namespace TelemetryDecoder.GuiElements
{
    class DoubleBufferedPanel : Panel
    {
        public DoubleBufferedPanel()
        {
            DoubleBuffered = true;
        }
    }
}
