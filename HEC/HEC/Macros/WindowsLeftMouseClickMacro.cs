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
    public class WindowsLeftMouseClickMacro : Macro
    {
        public WindowsLeftMouseClickMacro()
        {
            this.Title = "Left Click";
            this.AddCommand(new MouseCommand(MouseStates.L_CLICK));
        }
    }
}
