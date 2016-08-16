using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Diagnostics;

namespace HEC
{
    class WindowReader
    {
        [DllImport("user32.dll")]
        static extern IntPtr GetForegroundWindow();
        [DllImport("user32.dll")]
        static extern int GetWindowText(IntPtr hWnd, StringBuilder text, int count);

        public Windows GetActiveWindow()
        {
            String windowTitle = GetActiveWindowTitle();
            return GetWindowForTitle(windowTitle);
        }

        private Windows GetWindowForTitle(String title)
        {
            if (title == null) return Windows.GENERIC;

            if (title.Contains("Chrome"))
            {
                return Windows.CHROME;
            }
            if (title.Contains("VLC"))
            {
                return Windows.VLC;
            }
            if (title.Contains("Spotify"))
            {
                return Windows.SPOTIFY;
            }
            return Windows.GENERIC;
        }

        private string GetActiveWindowTitle()
        {
            const int nChars = 256;
            StringBuilder Buff = new StringBuilder(nChars);
            IntPtr handle = GetForegroundWindow();

            if (GetWindowText(handle, Buff, nChars) > 0)
            {
                return Buff.ToString();
            }
            return null;
        }
    }
}
