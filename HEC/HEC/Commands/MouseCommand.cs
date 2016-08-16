using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsInput;
using WindowsInput.Native;

namespace HEC.Commands
{
    public enum MouseStates { L_DOWN, L_UP, L_CLICK, R_DOWN, R_UP, R_CLICK, HORIZ_SCROLL,
                              VERT_SCROLL }
    class MouseCommand : Command
    {
        private MouseStates State;

        public MouseCommand(MouseStates state)
        {
            this.State = state;
            this.simulator = new InputSimulator();
        }

        public override void Run()
        {
            switch (State)
            {
                case MouseStates.L_UP:
                    simulator.Mouse.LeftButtonUp();
                    break;
                case MouseStates.R_UP:
                    simulator.Mouse.RightButtonUp();
                    break;
                case MouseStates.L_DOWN:
                    simulator.Mouse.LeftButtonDown();
                    break;
                case MouseStates.R_DOWN:
                    simulator.Mouse.RightButtonDown();
                    break;
                case MouseStates.L_CLICK:
                    simulator.Mouse.LeftButtonClick();
                    break;
                case MouseStates.R_CLICK:
                    simulator.Mouse.RightButtonClick();
                    break;
                default:
                    break;
            }
        }
    }
}
