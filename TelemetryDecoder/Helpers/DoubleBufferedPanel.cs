using System.Windows.Forms;

namespace TelemetryDecoder.Helpers
{
    class DoubleBufferedPanel : Panel
    {
        public DoubleBufferedPanel()
        {
            DoubleBuffered = true;
        }
    }
}
