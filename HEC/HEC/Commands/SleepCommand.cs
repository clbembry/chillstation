using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace HEC.Commands
{
    class SleepCommand : Command
    {
        private int Duration;
        public SleepCommand(int duration)
        {
            this.Duration = duration;
        }
        public override void Run()
        {
            Thread.Sleep(Duration);
        }
    }
}
