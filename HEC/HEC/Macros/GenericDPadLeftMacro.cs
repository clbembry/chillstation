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
    public class GenericDPadLeftMacro : Macro
    {
        public GenericDPadLeftMacro()
        {
            this.Title = "DPad Left";
            this.AddCommand(new KeyboardCommand(VirtualKeyCode.LEFT, KeyStates.PRESS));
        }
    }
}