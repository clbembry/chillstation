using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HEC.Commands;

namespace HEC.Macros
{
    public abstract class Macro
    {
        public String Title;
        protected List<Command> commands;

        protected void AddCommand(Command command)
        {
            if (commands == null) commands = new List<Command>();
            commands.Add(command);
        }
        public void Run()
        {
            foreach (Command command in commands)
            {
                command.Run();
            }
        }
        public virtual void Run(int magnitude)
        {
            foreach (Command command in commands)
            {
                command.Run(magnitude);
            }
        }

        public override string ToString()
        {
            return Title;
        }
    }
}
