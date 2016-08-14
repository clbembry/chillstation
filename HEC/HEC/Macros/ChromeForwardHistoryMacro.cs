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
    public class ChromeForwardHistoryMacro : Macro
    {
        public ChromeForwardHistoryMacro()
        {
            this.Title = "Forward";
            this.AddCommand(new KeyboardCommand(VirtualKeyCode.RIGHT, KeyStates.ALT));
        }
    }
}
