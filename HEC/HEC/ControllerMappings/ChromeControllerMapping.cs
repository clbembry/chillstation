using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HEC.Macros;

namespace HEC.ControllerMappings
{
    class ChromeControllerMapping : ControllerMapping
    {
        protected override void SetMacros()
        {
            base.SetMacros();

            macros["ChromeForwardHistory"] = new ChromeForwardHistoryMacro();
            macros["ChromeBackwardHistory"] = new ChromeBackwardHistoryMacro();
            macros["ChromeNextTab"] = new ChromeNextTabMacro();
            macros["ChromePreviousTab"] = new ChromePreviousTabMacro();
        }

        public override void PerformActionLBumper()
        {
            macros["ChromeBackwardHistory"].Run();
        }
        public override void PerformActionRBumper()
        {
            macros["ChromeForwardHistory"].Run();
        }

        public override void PerformActionRTRBumper()
        {
            macros["ChromeNextTab"].Run();
        }
        public override void PerformActionRTLBumper()
        {
            macros["ChromePreviousTab"].Run();
        }

    }
}
