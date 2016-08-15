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
            macros[Buttons.START] = ShowApps;
        }
    }
}
