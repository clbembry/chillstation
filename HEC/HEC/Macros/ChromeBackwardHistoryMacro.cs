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
    class ChromeBackwardHistoryMacro : Macro
    {
        public ChromeBackwardHistoryMacro()
        {
            this.Title = "Back";
            this.AddCommand(new KeyboardCommand(VirtualKeyCode.LEFT, KeyStates.ALT));
        }
    }
}
