using System;

namespace Memento
{
    class Program
    {
        /*
        -  INTENÇÃO: sem violar o encapsulamento, capturar e externalizar um estado interno de um objeto, de maneira que
                     o objeto possa ser restaurado para este estado mais tarde.
             */
        static void Main(string[] args)
        {
            // Cria objeto vendedor
            Vendedor vendedor = new Vendedor("Douglas", 100000.0);

            Console.WriteLine($"{vendedor.Nome} - Total de Vendas {vendedor.TotalDeVendas}");

            // Salva estado interno
            VendasMemory memory = new VendasMemory();
            memory.setMemento(vendedor.createMemento());

            // Altera os valores dos atributos do objeto vendedor
            vendedor.Nome = "Pedro";
            vendedor.TotalDeVendas = 5000.0;

            Console.WriteLine($"{vendedor.Nome} - Total de Vendas {vendedor.TotalDeVendas}");

            // Restaura memento para o primeiro vendedor
            vendedor.restoreMemento(memory.GetMemento());

            Console.WriteLine($"{vendedor.Nome} - Total de Vendas {vendedor.TotalDeVendas}");

        }
    }
}
