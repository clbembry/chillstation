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
    public class GenericDPadRightMacro : Macro
    {
        public GenericDPadRightMacro()
        {
            this.Title = "DPad Right";
            this.AddCommand(new KeyboardCommand(VirtualKeyCode.RIGHT, KeyStates.PRESS));
        }
    }
}