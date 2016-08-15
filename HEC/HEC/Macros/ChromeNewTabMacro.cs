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
    class ChromeNewTabMacro : Macro
    {
        public ChromeNewTabMacro()
        {
            this.Title = "New Tab";
            this.AddCommand(new KeyboardCommand(VirtualKeyCode.VK_T, KeyStates.CTRL));
        }
    }
}
