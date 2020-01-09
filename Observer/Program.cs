using System;

namespace Observer
{
    class Program
    {
        /*
        - INTENÇÃO: definir uma depend~encia um-para-muitos entre objetos, de maneira que quando um objeto muda
                    de estado todos os seus dependentes são notificados e atualizados automaticamente
             */
        static void Main(string[] args)
        {
            //Observador
            CarroPolicia cp = new CarroPolicia();

            //Observado
            CarroRoubado cr = new CarroRoubado();

            // Adicionar observador ao observado
            cr.addObserver(cp);

            cr.frente();
            cr.direita();
            cr.frente();
            cr.esquerda();
            cr.para();
        }
    }
}
