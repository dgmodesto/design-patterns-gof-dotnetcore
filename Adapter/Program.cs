using System;

namespace Adapter
{
    class Program
    {
        /*
         - INTENÇÃO:  converter a interface de uma classe em outra interface, esperada pelos clientes.
                    O Adapter permite que classes com interfaces incompativeis trabalhem em conjunto o que,
                    de outra forma, seria impossível.
        - Equilibrar interfaces de diferentes classes.
             */
        static void Main(string[] args)
        {
            // Target
            TomadaBrasileira tomadaBras = new TomadaBrasileira();

            //Adaptado
            PlugAmericano plugEUA = new PlugAmericano();

            //
            AdapterEUAtoBrasil tomadaModificada = new AdapterEUAtoBrasil();
            var result = tomadaModificada.conecta(plugEUA);
            Console.WriteLine(result);
        }
    }
}
