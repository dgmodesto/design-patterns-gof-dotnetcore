using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    public class ArvoreNatal : Arvore
    {
        public override void showEnfeites()
        {
            Console.WriteLine("Árvore de Natal, ");
        }
    }
}
