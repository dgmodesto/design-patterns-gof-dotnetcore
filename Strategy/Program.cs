using System;

namespace Strategy
{
    class Program
    {
        /*
        - INTENÇÃO: definir uma família de algoritmos, encapsular cada uma delas e torná-las intercambiàveis.
                    Strategy permite que o algoritmo varie independentemente dos clientes que o utilizam.
        - Encapsular algoritmos ("estratégias") como um objeto.
             */
        static void Main(string[] args)
        {

            Vetor v = new Vetor(new BubbleSort());
            v.ordenar();

            v.setAlgoritmo(new MergeSort());
            v.ordenar();


            v.setAlgoritmo(new QuickSort());
            v.ordenar();
        }
    }
}
