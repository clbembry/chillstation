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
    public class ChromeNextTabMacro : Macro
    {
        public ChromeNextTabMacro()
        {
            this.Title = "Next Tab";
            this.AddCommand(new KeyboardCommand(VirtualKeyCode.TAB, KeyStates.CTRL));
        }
    }
}
