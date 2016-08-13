using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HEC.Macros;

namespace HEC.ControllerMappings
{
    class DesktopControllerMapping : ControllerMapping
    {

        public override void setMacros()
        {
            base.setMacros();

            Macro arrowUp = new ArrowKeyUpMacro();
            macros.Add("ArrowUp", arrowUp);
            Macro arrowRight = new ArrowKeyRightMacro();
            macros.Add("ArrowRight", arrowRight);
            Macro arrowDown = new ArrowKeyDownMacro();
            macros.Add("ArrowDown", arrowDown);
            Macro arrowLeft = new ArrowKeyLeftMacro();
            macros.Add("ArrowLeft", arrowLeft);

            Macro enterKeyPress = new EnterKeyPressMacro();
            macros.Add("EnterKeyPress", enterKeyPress);

        }

        public override void performActionA()
        {
            base.performActionA();
            macros["EnterKeyPress"].run();
        }

        public override void performActionB()
        {
            base.performActionB();
        }

        public override void performActionX()
        {
            base.performActionX();
        }

        public override void performActionY()
        {
            base.performActionY();
        }

        public override void performActionDPadUp()
        {
            base.performActionDPadUp();
            macros["ArrowUp"].run();
        }

        public override void performActionDPadRight()
        {
            base.performActionDPadRight();
            macros["ArrowRight"].run();
        }

        public override void performActionDPadDown()
        {
            base.performActionDPadDown();
            macros["ArrowDown"].run();
        }

        public override void performActionDPadLeft()
        {
            base.performActionDPadLeft();
            macros["ArrowLeft"].run();
        }

    }
}
