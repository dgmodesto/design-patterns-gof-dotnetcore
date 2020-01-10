using System;
using System.Collections.Generic;
using System.Text;

namespace Memento
{
    public class VendasMemory
    {
        private Memento memento;

        public Memento GetMemento()
        {
            return memento;
        }

        public void setMemento(Memento memento)
        {
            this.memento = memento;
        }
    }
}
