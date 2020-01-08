using System;
using System.Collections.Generic;
using System.Text;

namespace Command
{
    public class Soma : CommandPattern
    {
        private Calculadora calculadora;
        private int numero;

        public Soma(Calculadora calculadora, int numero)
        {
            this.calculadora = calculadora;
            this.numero = numero;
        }

        public override void execute()
        {
            calculadora.setValor(calculadora.getValor() + numero);
            Console.WriteLine(calculadora.getValor());
        }

        public override void undo()
        {
            calculadora.setValor(calculadora.getValor() - numero);
            Console.WriteLine(calculadora.getValor());
        }
    }
}
