using System;
using System.Collections.Generic;
using System.Text;

namespace Observer
{
    //Observador
    public class CarroPolicia : ICarro, IObserver
    {
        public void direita()
        {
            Console.WriteLine("Viatura vira à direita");

        }

        public void esquerda()
        {
            Console.WriteLine("Viatura vira à esquerda");
        }

        public void para()
        {
            Console.WriteLine("Viatura para");

        }

        public void update(Observable arg0, object arg1)
        {
            CarroRoubado carroRoubado = (CarroRoubado)arg0;

            string acao = arg1.ToString();

            switch(acao)
            {
                case "frente":
                    this.frente();
                    break;
                case "direita":
                    this.direita();
                    break;
                case "esquerda":
                    this.esquerda();
                    break;
                case "para":
                    this.para();
                    break;
            }
        }

        public void frente()
        {
            Console.WriteLine("Viatura segue em frente");


        }
    }
}
