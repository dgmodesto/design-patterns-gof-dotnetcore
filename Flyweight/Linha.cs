using System;
using System.Collections.Generic;
using System.Text;

namespace Flyweight
{
    public class Linha : Figura
    {
        public override void desenha(string cor)
        {
            Console.WriteLine("linha " + cor);
        }
    }
}
