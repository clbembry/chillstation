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
    public class VLCPausePlayMacro : Macro
    {
        public VLCPausePlayMacro()
        {
            this.Title = "Play/Pause";
            this.AddCommand(new KeyboardCommand(VirtualKeyCode.SPACE, KeyStates.PRESS));
        }
    }
}
