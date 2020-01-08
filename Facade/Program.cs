using System;

namespace Facade
{
    class Program
    {
        /*
        - INTENÇÃO: fornecer uma interface unificada para um conjunto de interfaces em um subsistema.
                    Facade define uma interface de nível mais altor que torna o subsistema mais fácil de ser usado.
        - Uma única classe representa um substema inteiro
             */
        static void Main(string[] args)
        {
            FacadePattern facade = new FacadePattern();
            facade.MethodA();
        }
    }
}
