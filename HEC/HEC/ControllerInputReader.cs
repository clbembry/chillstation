using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SharpDX.XInput;
using System.Threading;
using System.ComponentModel;

namespace HEC
{
    class ControllerInputReader
    {
        private Controller controller;
        private int[] LeftThumbstickOffset;
        private int[] RightThumbstickOffset;

        public int[] LeftthumbstickOffset { get; private set; }

        public ControllerInputReader()
        {
            InitController();

            State startState = controller.GetState();

            LeftThumbstickOffset = new int[2];
            LeftThumbstickOffset[0] = -1 * (startState.Gamepad.LeftThumbX);
            LeftThumbstickOffset[1] = -1 * (startState.Gamepad.LeftThumbY);

            RightThumbstickOffset = new int[2];
            RightThumbstickOffset[0] = -1 * (startState.Gamepad.RightThumbX);
            RightThumbstickOffset[1] = -1 * (startState.Gamepad.RightThumbY);
        }

        public State GetState()
        {
            if (controller == null)
            {
                return new State();
            }
            return controller.GetState();
        }

        public int[] GetThumbCoordinates()
        {
            int[] coordinates = new int[4];
            int leftThumbX = controller.GetState().Gamepad.LeftThumbX;
            int leftThumbY = controller.GetState().Gamepad.LeftThumbY;
            int rightThumbX = controller.GetState().Gamepad.RightThumbX;
            int rightThumbY = controller.GetState().Gamepad.RightThumbY;

            coordinates[0] = leftThumbX + LeftThumbstickOffset[0];
            coordinates[1] = leftThumbY + LeftThumbstickOffset[1];
            coordinates[2] = rightThumbX + RightThumbstickOffset[0];
            coordinates[3] = rightThumbY + RightThumbstickOffset[1];

            return coordinates;
        }

        public bool CanRead()
        {
            if (controller == null)
            {
                return false;
            }
            return controller.IsConnected;
        }

        private void InitController()
        {
            var controllers = new[] { new Controller(UserIndex.One), new Controller(UserIndex.Two), new Controller(UserIndex.Three), new Controller(UserIndex.Four) };
            foreach (var selectControler in controllers)
            {
                if (selectControler.IsConnected)
                {
                    this.controller = selectControler;
                    break;
                }
            }
        }
    }
}
