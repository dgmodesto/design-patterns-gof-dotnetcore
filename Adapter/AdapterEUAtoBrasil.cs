using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter
{
    public class AdapterEUAtoBrasil : TomadaBrasileira
    {
        public string conecta(PlugAmericano plug)
        {
            return plug.obtemEletricidade() + this.getNomeRede();
        }
    }
}
