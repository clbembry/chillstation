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
    public class GenericDPadUpMacro : Macro
    {
        public GenericDPadUpMacro()
        {
            this.Title = "DPad Up";
            this.AddCommand(new KeyboardCommand(VirtualKeyCode.UP, KeyStates.PRESS));
        }
    }
}
