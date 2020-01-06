using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter
{
    public class PlugBrasileiro : Plug
    {
        public override string obtemEletricidade()
        {
            return "Plug brasileiro conectado à ";
        }

    }
}
