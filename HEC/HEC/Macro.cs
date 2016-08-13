using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsInput;
using WindowsInput.Native;

namespace HEC
{
    public abstract class Macro
    {
        protected InputSimulator simulator;

        public Macro()
        {
            simulator = new InputSimulator();
        }

        public virtual void run()
        {
            // override
        }

        public override string ToString()
        {
            return base.ToString();
        }

    }
}
