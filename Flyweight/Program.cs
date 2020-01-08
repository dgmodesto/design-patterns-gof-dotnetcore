using System;

namespace Flyweight
{
    class Program
    {
        /*
        - INTENÇÃO: usar compartilhamento para suportar eficientemente grandes quantidades de objetos de granularidade fina.         
             */
        static void Main(string[] args)
        {
            Figura f = FiguraFactory.getFigura("linha");
            f.desenha("branca");

            f = FiguraFactory.getFigura("oval preenchida");
            f.desenha("vermelha");

            f = FiguraFactory.getFigura("oval não preenchida");
            f.desenha("verde");

        }
    }
}
