using System;

namespace AbstractFactory
{
    class Program
    {
        /*
         - INTENÇÃO: fornecer uma inteface para craição de famílias de objetos relacionados 
                     ou dependentes sem especificar suas classes concretas
         - Cria uma instância de várias famílias de classe
         - Utilizado para familias de classes bem definidas
             */
        static void Main(string[] args)
        {
            // Empresa Onibus
            EmpresaOnibus viacaoXYZ = new ConcreteEmpresaOnibus();

            // Emite passagens
            PassagemOnibusUrbano passagemLocal = viacaoXYZ.emitePassagemOnibusUrbano("São Paulo", "Campinas", new DateTime(2020, 01, 10, 10, 20, 00));
            PassagemOnibusInterestadual passagemInter = viacaoXYZ.emitePassagemOnibusInterestadual("São Paulo", "Rio de Janeiro", new DateTime(2020, 03, 25, 15, 30, 00));

            // Exibe detalhe das passagens
            Console.WriteLine(passagemLocal.exibeDetalhe());
            Console.WriteLine(passagemInter.exibeDetalhe());
        }
    }
}
