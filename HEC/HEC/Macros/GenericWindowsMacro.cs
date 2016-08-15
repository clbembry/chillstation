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
    public class GenericWindowsMacro : Macro
    {
        public GenericWindowsMacro()
        {
            this.Title = "Windows";
            this.AddCommand(new KeyboardCommand(VirtualKeyCode.LWIN, KeyStates.PRESS));
        }
    }
}
