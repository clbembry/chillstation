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
    public class ShowAppsMacro : Macro
    {
        public ShowAppsMacro()
        {
            this.Title = "My Apps";
            this.AddCommand(new KeyboardCommand(VirtualKeyCode.TAB, KeyStates.WIN));
        }
    }
}
