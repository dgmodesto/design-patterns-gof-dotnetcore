using System;
using System.Collections.Generic;
using System.Text;

namespace Flyweight
{
    public class FiguraFactory
    {
        private static readonly Dictionary<string, Figura> figuras = new Dictionary<string, Figura>();

        public static Figura getFigura(string nome) {
            var fig = figuras.GetValueOrDefault(nome);

            if(fig == null)
            {
                if(nome.Equals("oval preenchida"))
                {
                    fig = new Oval(true);
                }
                else if (nome.Equals("oval não preenchida"))
                {
                    fig = new Oval(false);
                }
                else if (nome.Equals("linha"))
                {
                    fig = new Linha();
                }

                figuras.Add(nome, fig);
            }

            return fig;
        }
    }
}
