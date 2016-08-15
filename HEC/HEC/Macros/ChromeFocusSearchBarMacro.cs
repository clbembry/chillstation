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
    class ChromeFocusSearchBarMacro : Macro
    {
        public ChromeFocusSearchBarMacro()
        {
            this.Title = "Search";
            this.AddCommand(new KeyboardCommand(VirtualKeyCode.F6, KeyStates.SHIFT));
        }
    }
}
