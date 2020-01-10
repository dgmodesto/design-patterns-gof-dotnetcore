using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsability
{
    public class Compra
    {
        private double valor;

        public double Valor
        {
            get { return valor; }
            set { valor = value; }
        }


        public Compra(double valor)
        {
            this.Valor = valor;
        }

    }
}
