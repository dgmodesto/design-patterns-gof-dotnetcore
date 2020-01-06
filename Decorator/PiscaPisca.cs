using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    public class PiscaPisca : Decoracao
    {
        public PiscaPisca(Arvore arvore) : base(arvore)
        {
        }

        public override void showEnfeites()
        {
            base.showEnfeites();
            Console.Write("Pisca-Pisca, ");
        }
    }
}
