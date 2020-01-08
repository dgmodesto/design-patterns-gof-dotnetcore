using System;
using System.Collections.Generic;
using System.Text;

namespace Command
{
    public abstract class CommandPattern
    {
        public abstract void execute();
        public abstract void undo();

    }
}
