using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsability
{
    class Presidente : TomadorDecisao
    {
        public override void aprova(Compra compra)
        {
            if (compra.Valor < 1000000)
            {
                Console.WriteLine("Compra aprovada pelo Presidente");
            }
            else
            {
                Console.WriteLine("Compra não aprovada");
            }
        }
    }
}
