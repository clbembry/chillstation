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
    class ContextMacro : Macro
    {
        public ContextMacro()
        {
            this.Title = "Context";
            this.AddCommand(new KeyboardCommand(VirtualKeyCode.APPS, KeyStates.PRESS));
        }
    }
}
