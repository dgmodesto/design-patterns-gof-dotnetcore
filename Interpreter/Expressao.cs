using System;
using System.Collections.Generic;
using System.Text;

namespace Interpreter
{
    public abstract class Expressao
    {
        public void Interpret(Contexto contexto)
        {
            if (contexto.getInput().Length == 0)
            {
                return;
            }
            else if (contexto.getInput().StartsWith(Nove()))
            {
                contexto.setOutput(contexto.getOutput() + (9 * Multiplicador()));
                contexto.setInput(contexto.getInput().Substring(2));
            }
            else if (contexto.getInput().StartsWith(Quatro()))
            {
                contexto.setOutput(contexto.getOutput() + (4 * Multiplicador()));
                contexto.setInput(contexto.getInput().Substring(2));
            }
            else if (contexto.getInput().StartsWith(Cinco()))
            {
                contexto.setOutput(contexto.getOutput() + (5 * Multiplicador()));
                contexto.setInput(contexto.getInput().Substring(1));
            }

            while(contexto.getInput().StartsWith(Um()))
            {
                contexto.setOutput(contexto.getOutput() + (1 * Multiplicador()));
                contexto.setInput(contexto.getInput().Substring(1));
            }
        }

        public abstract string Um();

        public abstract string Cinco();

        public abstract string Quatro();

        public abstract int Multiplicador();

        public abstract string Nove();
    }
}
