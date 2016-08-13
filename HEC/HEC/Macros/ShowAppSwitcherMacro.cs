using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsInput;
using WindowsInput.Native;

namespace HEC.Macros
{
    class ShowAppSwitcherMacro : Macro
    {
        public override void run()
        {
            base.run();

            VirtualKeyCode windowsKey = VirtualKeyCode.LWIN;
            VirtualKeyCode tabKey = VirtualKeyCode.TAB;

            simulator.Keyboard.KeyDown(windowsKey);
            simulator.Keyboard.KeyDown(tabKey);
            simulator.Keyboard.KeyUp(windowsKey);
            simulator.Keyboard.KeyUp(tabKey);

        }
    }
}
