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
    class ChromeRefreshMacro : Macro
    {
        public ChromeRefreshMacro()
        {
            this.Title = "Refresh";
            this.AddCommand(new KeyboardCommand(VirtualKeyCode.F5, KeyStates.PRESS));
        }
    }
}
