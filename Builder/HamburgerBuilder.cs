using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    public class HamburgerBuilder : SanduicheBuilder
    {
        private Sanduiche s = new Hamburguer();
        public HamburgerBuilder()
        {
        }

        public override void abrePao()
        {
            Console.WriteLine("Abre pão de hambuger");
        }

        public override void insereIngredientes()
        {
            Console.WriteLine("Insere carne e queijo");
        }

        public override void fechaPao()
        {
            Console.WriteLine("Fecha pão de hambueguer");
        }

        public override Sanduiche getSanduiche()
        {
            Console.WriteLine("Hamburger está pronto!");
            return s;
        }
    }
}
