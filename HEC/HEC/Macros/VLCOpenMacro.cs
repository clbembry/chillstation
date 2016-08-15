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
    public class VLCOpenMacro : Macro
    {
        public VLCOpenMacro()
        {
            this.Title = "Open";
            this.AddCommand(new KeyboardCommand(VirtualKeyCode.VK_O, KeyStates.CTRL));
            Thread.Sleep(500);
            this.AddCommand(new KeyboardCommand(VirtualKeyCode.TAB, KeyStates.PRESS));
            this.AddCommand(new KeyboardCommand(VirtualKeyCode.TAB, KeyStates.PRESS));
            this.AddCommand(new KeyboardCommand(VirtualKeyCode.TAB, KeyStates.PRESS));
            this.AddCommand(new KeyboardCommand(VirtualKeyCode.TAB, KeyStates.PRESS));
            this.AddCommand(new KeyboardCommand(VirtualKeyCode.TAB, KeyStates.PRESS));
            this.AddCommand(new KeyboardCommand(VirtualKeyCode.TAB, KeyStates.PRESS));
            this.AddCommand(new KeyboardCommand(VirtualKeyCode.TAB, KeyStates.PRESS));
            this.AddCommand(new KeyboardCommand(VirtualKeyCode.TAB, KeyStates.PRESS));
        }
    }
}
