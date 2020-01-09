using System;
using System.Collections.Generic;
using System.Text;

namespace Observer
{
    // Observado
    public class CarroRoubado : Observable, ICarro
    {


        public void direita()
        {
            acao = "direita";
            Console.WriteLine("Carro roubado vira a direita");
            this.mudaEstado();

        }

        public void esquerda()
        {
            acao = "esquerda";
            Console.WriteLine("Carro roubado vira a esquerda");
            this.mudaEstado();
        }

        public void para()
        {
            acao = "para";
            Console.WriteLine("Carro roubado para");
            this.mudaEstado();
        }

        public void frente()
        {
            acao = "frente";
            Console.WriteLine("Carro roubado segue em frente");
            this.mudaEstado();

        }

        public void mudaEstado()
        {
            setChanged(acao); // Mudou o estado;
            notifyObservers(); // Notifica os observadores
        }
    }
}
