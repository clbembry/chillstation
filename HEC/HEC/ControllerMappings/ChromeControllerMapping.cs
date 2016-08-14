using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HEC.Macros;

namespace HEC.ControllerMappings
{
    class ChromeControllerMapping : GenericControllerMapping
    {
        protected override void SetMacros()
        {
            base.SetMacros();

            macros[Buttons.R_BUMPER] = new ChromeForwardHistoryMacro();
            macros[Buttons.L_BUMPER] = new ChromeBackwardHistoryMacro();
            macros[Buttons.RT_R_BUMPER] = new ChromeNextTabMacro();
            macros[Buttons.RT_L_BUMPER] = new ChromePreviousTabMacro();
        }

    }
}
