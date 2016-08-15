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
    public class GenericReturnMacro : Macro
    {
        public GenericReturnMacro()
        {
            this.Title = "Return";
            this.AddCommand(new KeyboardCommand(VirtualKeyCode.RETURN, KeyStates.PRESS));
        }
    }
}
