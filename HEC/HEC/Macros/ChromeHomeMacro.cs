using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HEC.Commands;
using WindowsInput;
using WindowsInput.Native;

namespace HEC.Macros
{
    public class ChromeHomeMacro : Macro
    {
        public ChromeHomeMacro()
        {
            //"Top of Page" or "Home"
            this.Title = "Top of Page";
            this.AddCommand(new KeyboardCommand(VirtualKeyCode.HOME, KeyStates.PRESS));
        }
    }
}
