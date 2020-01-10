using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsability
{
    public class Diretor : TomadorDecisao
    {
        public override void aprova(Compra compra)
        {
            if (compra.Valor < 10000)
            {
                Console.WriteLine("Compra aprovada pelo Diretor");
            }
            else if (sucessor != null)
            {
                sucessor.aprova(compra);
            }
        }
    }
}
