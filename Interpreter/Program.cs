using System;
using System.Collections.Generic;

namespace Interpreter
{
    class Program
    {
        /*
        - INTENÇÃO: dada uma linguagem, definir uma representação para a sua gramática juntamente com um interpretador que
                    usa representação para interpretar sentenças da linguagem.
        - Uma forma de incluir elementos da linguagem em um programa.
        - Usa classes para representar cada regra de uma gramatica (expressão regular).
             */
        static void Main(string[] args)
        {
            string romano = "MCMXXVIII";
            Contexto contexto = new Contexto(romano);

            //Lista de expressões
            List<Expressao> tree = new List<Expressao>();
            tree.Add(new Milhar());
            tree.Add(new Centena());
            tree.Add(new Dezena());
            tree.Add(new Unidade());

            // Interpreter
            tree.ForEach(exp =>
            {
                exp.Interpret(contexto);
            });

            Console.WriteLine(contexto.getOutput());
        }
    }
}
