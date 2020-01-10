using System;
using System.Collections.Generic;
using System.Text;

namespace TemplateMethod
{
    public class Basquete : Game
    {
        public override void endPlay()
        {
            Console.WriteLine("Termina a partida de basquete");
        }

        public override void initialized()
        {
            Console.WriteLine("5 Jogadores.");
        }

        public override void startPlay()
        {
            Console.WriteLine("Inicia a partida de basquete.");
        }
    }
}
