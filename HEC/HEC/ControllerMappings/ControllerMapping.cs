using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HEC.Macros;

namespace HEC
{
    public abstract class ControllerMapping
    {
        public Dictionary<Buttons, Macro> macros;

        public ControllerMapping()
        {
            macros = new Dictionary<Buttons, Macro>();
            this.SetMacros();
        }

        protected abstract void SetMacros();

        public void PerformActionStart() {
            if (macros.ContainsKey(Buttons.START))
                macros[Buttons.START].Run();
        }

        public void PerformActionMenu()
        {
            if (macros.ContainsKey(Buttons.MENU))
                macros[Buttons.MENU].Run();
        }

        public void PerformActionA() {
            if (macros.ContainsKey(Buttons.A))
                macros[Buttons.A].Run();
        }
        public void PerformActionB() {
            if (macros.ContainsKey(Buttons.B))
                macros[Buttons.B].Run();
        }
        public void PerformActionX() {
            if (macros.ContainsKey(Buttons.X))
                macros[Buttons.X].Run();
        }
        public void PerformActionY() {
            if (macros.ContainsKey(Buttons.Y))
                macros[Buttons.Y].Run();
        }
        public void PerformActionDPadUp() {
            if (macros.ContainsKey(Buttons.DPAD_UP))
                macros[Buttons.DPAD_UP].Run();
        }
        public void PerformActionDPadRight() {
            if (macros.ContainsKey(Buttons.DPAD_RIGHT))
                macros[Buttons.DPAD_RIGHT].Run();
        }
        public void PerformActionDPadDown() {
            if (macros.ContainsKey(Buttons.DPAD_DOWN))
                macros[Buttons.DPAD_DOWN].Run();
        }
        public void PerformActionDPadLeft() {
            if (macros.ContainsKey(Buttons.DPAD_LEFT))
                macros[Buttons.DPAD_LEFT].Run();
        }
        public void PerformActionLBumper() {
            if (macros.ContainsKey(Buttons.L_BUMPER))
                macros[Buttons.L_BUMPER].Run();
        }
        public void PerformActionRBumper() {
            if (macros.ContainsKey(Buttons.R_BUMPER))
                macros[Buttons.R_BUMPER].Run();
        }

        public void PerformActionLTA() {
            if (macros.ContainsKey(Buttons.LT_A))
                macros[Buttons.LT_A].Run();
        }
        public void PerformActionLTB() {
            if (macros.ContainsKey(Buttons.LT_B))
                macros[Buttons.LT_B].Run();
        }
        public void PerformActionLTX() {
            if (macros.ContainsKey(Buttons.LT_X))
                macros[Buttons.LT_X].Run();
        }
        public void PerformActionLTY() {
            if (macros.ContainsKey(Buttons.LT_Y))
                macros[Buttons.LT_Y].Run();
        }
        public void PerformActionLTDPadUp() {
            if (macros.ContainsKey(Buttons.LT_DPAD_UP))
                macros[Buttons.LT_DPAD_UP].Run();
        }
        public void PerformActionLTDPadRight() {
            if (macros.ContainsKey(Buttons.LT_DPAD_RIGHT))
                macros[Buttons.LT_DPAD_RIGHT].Run();
        }
        public void PerformActionLTDPadDown() {
            if (macros.ContainsKey(Buttons.LT_DPAD_DOWN))
                macros[Buttons.LT_DPAD_DOWN].Run();
        }
        public void PerformActionLTDPadLeft() {
            if (macros.ContainsKey(Buttons.LT_DPAD_LEFT))
                macros[Buttons.LT_DPAD_LEFT].Run();
        }
        public void PerformActionLTLBumper() {
            if (macros.ContainsKey(Buttons.LT_L_BUMPER))
                macros[Buttons.LT_L_BUMPER].Run();
        }
        public void PerformActionLTRBumper() {
            if (macros.ContainsKey(Buttons.LT_R_BUMPER))
                macros[Buttons.LT_R_BUMPER].Run();
        }

        public void PerformActionRTA() {
            if (macros.ContainsKey(Buttons.RT_A))
                macros[Buttons.RT_A].Run();
        }
        public void PerformActionRTB () {
            if (macros.ContainsKey(Buttons.RT_B))
                macros[Buttons.RT_B].Run();
        }
        public void PerformActionRTX () {
            if (macros.ContainsKey(Buttons.RT_X))
                macros[Buttons.RT_X].Run();
        }
        public void PerformActionRTY () {
            if (macros.ContainsKey(Buttons.RT_Y))
                macros[Buttons.RT_Y].Run();
        }
        public void PerformActionRTDPadUp() {
            if (macros.ContainsKey(Buttons.RT_DPAD_UP))
                macros[Buttons.RT_DPAD_UP].Run();
        }
        public void PerformActionRTDPadRight() {
            if (macros.ContainsKey(Buttons.RT_DPAD_RIGHT))
                macros[Buttons.RT_DPAD_RIGHT].Run();
        }
        public void PerformActionRTDPadDown() {
            if (macros.ContainsKey(Buttons.RT_DPAD_DOWN))
                macros[Buttons.RT_DPAD_DOWN].Run();
        }
        public void PerformActionRTDPadLeft() {
            if (macros.ContainsKey(Buttons.RT_DPAD_LEFT))
                macros[Buttons.RT_DPAD_LEFT].Run();
        }
        public void PerformActionRTLBumper() {
            if (macros.ContainsKey(Buttons.RT_L_BUMPER))
                macros[Buttons.RT_R_BUMPER].Run();
        }
        public void PerformActionRTRBumper() {
            if (macros.ContainsKey(Buttons.RT_R_BUMPER))
                macros[Buttons.RT_R_BUMPER].Run();
        }
    }
}
