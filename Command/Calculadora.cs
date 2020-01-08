using System;
using System.Collections.Generic;
using System.Text;

namespace Command
{
    public class Calculadora
    {
        private int numero;
        public void setValor(int valor)
        {
            numero = valor;
        }

        public int getValor()
        {
            return numero;
        }

    }
}
