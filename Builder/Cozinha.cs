using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    public class Cozinha
    {
        public void fazSanduiche(SanduicheBuilder builder)
        {
            builder.abrePao();
            builder.insereIngredientes();
            builder.fechaPao();
        }
    }
}
