using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton
{
    public class Janela
    {
        private static Janela j = null;
        private string descricao = null;

        private Janela()
        {

        }

        public static Janela GetInstance(string descricao)
        {
            if (j == null)
            {
                j = new Janela();
                j.descricao = descricao;
            }

            return j;
        }

        public string getDescricao()
        {
            return descricao;
        }
    }
}
