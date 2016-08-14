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
        protected Dictionary<String, Macro> macros;

        public ControllerMapping()
        {
            macros = new Dictionary<string, Macro>();
            this.SetMacros();
        }

        protected virtual void SetMacros()
        {
            Macro ShowApps = new ShowAppsMacro();
            macros.Add("ShowApps", ShowApps);
            // override
        }

        public void PerformActionStart()
        {
            macros["ShowApps"].Run();
        }

        public void PerformActionMenu()
        {
            // not yet implemented
        }

        public virtual void PerformActionA() { }
        public virtual void PerformActionB() { }
        public virtual void PerformActionX() { }
        public virtual void PerformActionY() { }
        public virtual void PerformActionDPadUp() { }
        public virtual void PerformActionDPadRight() { }
        public virtual void PerformActionDPadDown() { }
        public virtual void PerformActionDPadLeft() { }
        public virtual void PerformActionLBumper() { }
        public virtual void PerformActionRBumper() { }

        public virtual void PerformActionLTA() { }
        public virtual void PerformActionLTB() { }
        public virtual void PerformActionLTX() { }
        public virtual void PerformActionLTY() { }
        public virtual void PerformActionLTDPadUp() { }
        public virtual void PerformActionLTDPadRight() { }
        public virtual void PerformActionLTDPadDown() { }
        public virtual void PerformActionLTDPadLeft() { }
        public virtual void PerformActionLTLBumper() { }
        public virtual void PerformActionLTRBumper() { }

        public virtual void PerformActionRTA() { }
        public virtual void PerformActionRTB () { }
        public virtual void PerformActionRTX () { }
        public virtual void PerformActionRTY () { }
        public virtual void PerformActionRTDPadUp() { }
        public virtual void PerformActionRTDPadRight() { }
        public virtual void PerformActionRTDPadDown() { }
        public virtual void PerformActionRTDPadLeft() { }
        public virtual void PerformActionRTLBumper() { }
        public virtual void PerformActionRTRBumper() { }
    }
}
