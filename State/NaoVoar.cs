using System;
using System.Collections.Generic;
using System.Text;

namespace State
{
    public class NaoVoar : Comportamento
    {
        public override void exec()
        {
            Console.WriteLine("Esta ave não voa");

        }
    }
}
