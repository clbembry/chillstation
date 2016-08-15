using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HEC.Macros;

namespace HEC.ControllerMappings
{
    public class VLCControllerMapping : GenericControllerMapping
    {
        public VLCControllerMapping()
        {
            macros[Buttons.A] = new VLCPausePlayMacro();
            macros[Buttons.X] = new VLCFullscreenMacro();
            macros[Buttons.Y] = new VLCOpenMacro();
        }
    }
}
