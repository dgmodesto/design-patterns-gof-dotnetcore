using System;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            var janela = Janela.GetInstance("Primeira Instância");
            Console.WriteLine(janela.getDescricao());

            var janela2 = Janela.GetInstance("Segunda Instância");
            Console.WriteLine(janela2.getDescricao());

            Console.ReadKey();
        }
    }
}
