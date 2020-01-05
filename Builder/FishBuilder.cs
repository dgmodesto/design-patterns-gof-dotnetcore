using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    public class FishBuilder : SanduicheBuilder
    {
        private Sanduiche s = new Hamburguer();
        public FishBuilder()
        {
        }

        public override void abrePao()
        {
            Console.WriteLine("Abre pão de fishbuger");
        }

        public override void insereIngredientes()
        {
            Console.WriteLine("Insere filé de peixe e queijo");
        }

        public override void fechaPao()
        {
            Console.WriteLine("Fecha pão de fishbuger");
        }

        public override Sanduiche getSanduiche()
        {
            Console.WriteLine("Fishburger está pronto!");
            return s;
        }
    }
}
