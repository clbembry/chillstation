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
    public class GenericEscapeMacro : Macro
    {
        public GenericEscapeMacro()
        {
            this.Title = "Esacpe";
            this.AddCommand(new KeyboardCommand(VirtualKeyCode.ESCAPE, KeyStates.PRESS));
        }
    }
}
