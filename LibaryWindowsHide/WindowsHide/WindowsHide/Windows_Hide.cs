using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace ExtLibraries
{
    public static class Windows_Hide
    {
        #region SubMethods
        // The two dll imports below will handle the window hiding.

        [DllImport("kernel32.dll")]
        static extern IntPtr GetConsoleWindow();

        [DllImport("user32.dll")]
        static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

        const int SW_HIDE = 0;

        #endregion

        #region Methods
        public static void Hide_Console()
        {
            var handle = GetConsoleWindow();                
            ShowWindow(handle, SW_HIDE);
        }
        #endregion
    }
}
