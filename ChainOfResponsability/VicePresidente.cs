using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsability
{
    class VicePresidente : TomadorDecisao
    {
        public override void aprova(Compra compra)
        {
            if (compra.Valor < 100000)
            {
                Console.WriteLine("Compra aprovada pelo Vice Presidente");
            }
            else if (sucessor != null)
            {
                sucessor.aprova(compra);
            }
        }
    }
}
