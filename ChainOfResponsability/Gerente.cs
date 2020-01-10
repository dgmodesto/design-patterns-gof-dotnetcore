using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsability
{
    public class Gerente : TomadorDecisao
    {
        public override void aprova(Compra compra)
        {
            if (compra.Valor < 1000)
            {
                Console.WriteLine("Compra aprovada pelo Gerente");
            }
            else if (sucessor != null)
            {
                sucessor.aprova(compra);
            }
        }
    }
}
