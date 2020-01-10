using System;
using System.Collections.Generic;
using System.Text;

namespace TemplateMethod
{
    public class Futebol : Game
    {
        public override void endPlay()
        {
            Console.WriteLine("Termina a partida de futebol");
        }

        public override void initialized()
        {
            Console.WriteLine("11 Jogadores.");
        }

        public override void startPlay()
        {
            Console.WriteLine("Inicia a partida de futebol.");
        }
    }
}
