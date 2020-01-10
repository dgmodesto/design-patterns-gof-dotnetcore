using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsability
{
    // Handler
    public abstract class TomadorDecisao
    {
        protected TomadorDecisao sucessor;

        public void setSucessor(TomadorDecisao sucessor)
        {
            this.sucessor = sucessor;
        }

        public abstract void aprova(Compra compra);
    }
}
