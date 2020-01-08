using System;

namespace Command
{
    class Program
    {
        /*
        - INTENÇÃO: encapsular uma solicitação como um objeto, desta forma permitindo parametrizar clientes com diferentes
                    solicitações, enfileirar ou fazer o registro (log) de solicitações e suportar operações que podem ser
                    desfeitas.
        - Encapsular comandos como um objeto.
             */
        static void Main(string[] args)
        {
            Calculadora calculadora = new Calculadora();

            // A classe invoker irá armazenar o histórico dos calculos;
            Invoker invoker = new Invoker();

            // Executar a operação de soma
            invoker.compute(new Soma(calculadora, 10));
            invoker.compute(new Soma(calculadora, 20));
            invoker.compute(new Soma(calculadora, 10));

            // Desfazer as duas útltimas operações
            invoker.undo(2);


        }
    }
}
