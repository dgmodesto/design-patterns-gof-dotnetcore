using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    public abstract class SanduicheBuilder
    {
        public abstract void abrePao();
        public abstract void insereIngredientes();
        public abstract void fechaPao();
        public abstract Sanduiche getSanduiche();
    }
}
