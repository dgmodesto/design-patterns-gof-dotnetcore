using System;
using System.Collections.Generic;
using System.Text;

namespace Flyweight
{
    public class Oval : Figura
    {
        private bool preenchido;
        public Oval(bool preenchido)
        {
            this.preenchido = preenchido;
        }
        public override void desenha(string cor)
        {
            if(preenchido)
            {
               Console.WriteLine("Figura oval preenchida " + cor);

            }
            else
            {
            Console.WriteLine("Figura oval não preenchida " + cor);

            }
        }
    }
}
