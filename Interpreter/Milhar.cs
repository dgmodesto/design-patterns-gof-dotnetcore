using System;
using System.Collections.Generic;
using System.Text;

namespace Interpreter
{
    public class Milhar : Expressao
    {
        public override string Um() { return "M"; }
        public override string Quatro() { return " "; }
        public override string Cinco() { return " "; }
        public override string Nove() { return " "; }
        public override int Multiplicador() { return 1000; }

    }
}
