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
    public class ChromeCloseTabMacro : Macro
    {
        public ChromeCloseTabMacro()
        {
            this.Title = "Close Tab";
            this.AddCommand(new KeyboardCommand(VirtualKeyCode.VK_W, KeyStates.CTRL));
        }
    }
}
