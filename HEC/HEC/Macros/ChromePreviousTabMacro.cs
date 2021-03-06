﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HEC.Commands;
using WindowsInput;
using WindowsInput.Native;

namespace HEC.Macros
{
    class ChromePreviousTabMacro : Macro
    {
        public ChromePreviousTabMacro()
        {
            this.Title = "Previous Tab";
            this.AddCommand(new KeyboardCommand(VirtualKeyCode.TAB, KeyStates.CTRL_SHIFT));
        }
    }
}
