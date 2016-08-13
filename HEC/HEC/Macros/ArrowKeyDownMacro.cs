using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsInput;
using WindowsInput.Native;

namespace HEC.Macros
{
    class ArrowKeyDownMacro : Macro
    {
        public override void run()
        {
            base.run();

            VirtualKeyCode windowsKey = VirtualKeyCode.DOWN;
            simulator.Keyboard.KeyPress(windowsKey);
        }
    }
}
