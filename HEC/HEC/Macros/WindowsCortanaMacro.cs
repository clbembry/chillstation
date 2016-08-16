using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HEC.Commands;
using WindowsInput;
using WindowsInput.Native;
using System.Threading;

namespace HEC.Macros
{
    public class WindowsCortanaMacro : Macro
    {
        public WindowsCortanaMacro()
        {
            this.Title = "Cortana";
            this.AddCommand(new KeyboardCommand(VirtualKeyCode.LWIN, KeyStates.PRESS));
            this.AddCommand(new SleepCommand(100));
            this.AddCommand(new KeyboardCommand(VirtualKeyCode.TAB, KeyStates.PRESS));
            this.AddCommand(new KeyboardCommand(VirtualKeyCode.RETURN, KeyStates.PRESS));
        }
    }
}
