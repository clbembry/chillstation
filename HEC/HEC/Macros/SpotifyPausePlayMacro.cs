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
    class SpotifyPausePlayMacro : Macro
    {
        public SpotifyPausePlayMacro()
        {
            this.Title = "Pause/Play";
            this.AddCommand(new KeyboardCommand(VirtualKeyCode.SPACE, KeyStates.PRESS));
        }
    }
}
