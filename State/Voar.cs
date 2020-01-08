using System;
using System.Collections.Generic;
using System.Text;

namespace State
{
    public class Voar : Comportamento
    {
        public override void exec()
        {
            Console.WriteLine("Esta ave voa");
        }
    }
}
