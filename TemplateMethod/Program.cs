using System;

namespace TemplateMethod
{
    class Program
    {
        /*
        - INTENÇÃO: definir o esqueleto de um algoritmo em uma operação, postergando (deferring) alguns passos
                    para subclasses. Template Method (Gabarito do Método) permite que subclasse redefinam
                    certos passos de um algoritmo sem mudar a estrutura do mesmo.
             */
        static void Main(string[] args)
        {
            // Iniciar uma partida de basquete
            Game gameB = new Basquete();
            gameB.play();

            // Iniciar uma partida de futebol
            Game gameF = new Futebol();
            gameF.play();
        }
    }
}
