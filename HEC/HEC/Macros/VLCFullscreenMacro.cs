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
    public class VLCFullscreenMacro : Macro
    {
        public VLCFullscreenMacro()
        {
            this.Title = "Toggle Fullscreen";
            this.AddCommand(new KeyboardCommand(VirtualKeyCode.VK_F, KeyStates.PRESS));
        }
    }
}
