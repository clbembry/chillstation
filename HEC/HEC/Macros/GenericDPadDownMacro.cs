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
    public class GenericDPadDownMacro : Macro
    {
        public GenericDPadDownMacro()
        {
            this.Title = "DPad Down";
            this.AddCommand(new KeyboardCommand(VirtualKeyCode.DOWN, KeyStates.PRESS));
        }
    }
}