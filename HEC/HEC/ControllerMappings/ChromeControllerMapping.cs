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

            macros[Buttons.A] = new ChromeEnterMacro();
            macros[Buttons.X] = new ChromeNewTabMacro();
            macros[Buttons.Y] = new ChromeFocusSearchBarMacro();
            macros[Buttons.L_BUMPER] = new ChromeBackwardHistoryMacro();
            macros[Buttons.R_BUMPER] = new ChromeForwardHistoryMacro();
            macros[Buttons.RT_A] = new ChromeRefreshMacro();
            macros[Buttons.RT_X] = new ChromeFullscreenMacro();
            macros[Buttons.RT_R_BUMPER] = new ChromeNextTabMacro();
            macros[Buttons.RT_L_BUMPER] = new ChromePreviousTabMacro();                   
        }

    }
}
