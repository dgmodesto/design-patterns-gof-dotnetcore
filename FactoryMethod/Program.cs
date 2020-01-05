using System;
using System.Globalization;

namespace FactoryMethod
{
    class Program
    {

        /*
            FACTORY METHOD
            - Intenção: definir uma interface para criar um objeto, mas deixar as subclasses decidirem
                        que classe instanciar.
            - Criar uma instância de várias classes derivadas.
             
             */

        static void Main(string[] args)
        {
            // Empresas de ônibus
            Empresa viacaoABCLocal = new EmpresaOnibusUrbano();
            Empresa viacaoXYZInter = new EmpresaOnibusInterEstadual();

            // Emite passagens
            Passagem passagemLocal = viacaoABCLocal.emitePassagem("São Paulo", "Campinas", new DateTime(2020, 01, 10, 10, 20,00));
            Passagem passagemInter = viacaoXYZInter.emitePassagem("São Paulo", "Rio de Janeiro", new DateTime(2020, 03, 25, 15, 30,00));


            // Exibe detalhe das passagens
            Console.WriteLine(passagemLocal.exibeDetalhe());
            Console.WriteLine(passagemInter.exibeDetalhe());
        }
    }
}
