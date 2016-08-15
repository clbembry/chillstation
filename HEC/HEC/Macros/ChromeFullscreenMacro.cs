using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HEC.Commands;
using WindowsInput;
using WindowsInput.Native;

namespace HEC.Macros
{
    class ChromeFullscreenMacro : Macro
    {
        public ChromeFullscreenMacro()
        {
            this.Title = "Fullscreen";
            this.AddCommand(new KeyboardCommand(VirtualKeyCode.F11, KeyStates.PRESS));
        }
    }
}
