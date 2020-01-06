using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    public class Estrela : Decoracao
    {
        public Estrela(Arvore arvore) : base(arvore)
        {
        }

        public override void showEnfeites()
        {
            base.showEnfeites();
            Console.Write("Estrela, ");
        }

    }
}
