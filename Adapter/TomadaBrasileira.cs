using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter
{
    public class TomadaBrasileira : Tomada<PlugBrasileiro>
    {
        public override string conecta(PlugBrasileiro plug)
        {
            return plug.obtemEletricidade() + this.getNomeRede();
        }


        public override string getNomeRede()
        {
            return "tomada brasileira";
        }
    }
}
