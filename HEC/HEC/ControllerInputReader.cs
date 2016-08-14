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
        
        public ControllerInputReader()
        {
            InitController();
        }

        public State GetState()
        {
            if (controller == null)
            {
                return new State();
            }
            return controller.GetState();
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
