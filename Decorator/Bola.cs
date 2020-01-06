using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    public class Bola : Decoracao
    {
        public Bola(Arvore arvore) : base(arvore)
        {
        }

        public override void showEnfeites()
        {
            base.showEnfeites();
            Console.Write("Bola, ");
        }
    }
}
