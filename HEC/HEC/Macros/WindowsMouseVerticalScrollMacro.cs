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
    public class WindowsMouseVerticalScrollMacro : Macro
    {
        public WindowsMouseVerticalScrollMacro()
        {
            this.Title = "Vertical Scroll";
            this.AddCommand(new MouseCommand(MouseStates.VERT_SCROLL));
        }
    }
}
