using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    public class Vetor
    {
        private AlgoritmoOrdenacao algoritmo;

        public Vetor(AlgoritmoOrdenacao algoritmo)
        {
            this.algoritmo = algoritmo;
        }

        public void ordenar()
        {
            algoritmo.sort();
        }

        public void setAlgoritmo(AlgoritmoOrdenacao algoritmo)
        {
            this.algoritmo = algoritmo;
        }

    }
}
