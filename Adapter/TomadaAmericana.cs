using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter
{
    public class TomadaAmericana : Tomada<PlugAmericano>
    {
        public override string conecta(PlugAmericano plug)
        {
            return plug.obtemEletricidade() + this.getNomeRede();
        }


        public override string getNomeRede()
        {
            return "tomada americana";
        }
    }
}
