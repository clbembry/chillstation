using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HEC.Macros;

namespace HEC.ControllerMappings
{
    public class GenericControllerMapping : ControllerMapping
    {
        protected override void SetMacros()
        {
            Macro ShowApps = new ShowAppsMacro();

            macros[Buttons.A] = new GenericReturnMacro();
            macros[Buttons.B] = new GenericEscapeMacro();
            //macros[Buttons.X] = new GenericXXXMacro();
            macros[Buttons.Y] = new GenericWindowsMacro();

            macros[Buttons.DPAD_UP] = new GenericDPadUpMacro();
            macros[Buttons.DPAD_DOWN] = new GenericDPadDownMacro();
            macros[Buttons.DPAD_LEFT] = new GenericDPadLeftMacro();
            macros[Buttons.DPAD_RIGHT] = new GenericDPadRightMacro();

            macros[Buttons.L_BUMPER] = new GenericLeftBumperMacro();
            macros[Buttons.R_BUMPER] = new GenericRightBumperMacro();

            macros[Buttons.MENU] = new WindowsCortanaMacro();
            macros[Buttons.START] = ShowApps;
            macros[Buttons.L_STICK] = new WindowsLeftMouseClickMacro();
        }
    }
}
