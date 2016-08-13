using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsInput;
using WindowsInput.Native;

namespace HEC.Macros
{
    class ArrowKeyLeftMacro : Macro
    {
        public override void run()
        {
            base.run();

            VirtualKeyCode windowsKey = VirtualKeyCode.LEFT;
            simulator.Keyboard.KeyPress(windowsKey);
        }
    }
}
