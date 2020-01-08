using System;
using System.Collections.Generic;
using System.Text;

namespace Command
{
    public class Invoker
    {
        private List<CommandPattern> comandos = new List<CommandPattern>();
        private int current = 0;

        public void compute(CommandPattern command)
        {
            command.execute();
            comandos.Add(command);
            current++;
        }

        public void undo(int levels)
        {
            for(int i=0; i < levels; i++)
            {
                if(current > 0)
                {
                    CommandPattern command = comandos[--current];
                    comandos.Remove(command);
                    command.undo();
                }
            }
        }
    }
}
