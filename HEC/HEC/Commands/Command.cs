using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsInput;
using WindowsInput.Native;

namespace HEC.Commands
{
    public class Command
    {
        protected InputSimulator simulator;

        public virtual void Run()
        {
            // override
        }
        public virtual void Run(int magnitude)
        {
            // override
        }

        protected virtual void Up(VirtualKeyCode key) {
            // override
        }
        protected virtual void Down(VirtualKeyCode key)
        {
            // override
        }
        protected virtual void Press(VirtualKeyCode key)
        {
            // override
        }
    }
}
