using System;

namespace Composite
{
    class Program
    {
        /*
        - INTENÇÃO: compor objetos em estruturas de árvore para representarem hierarquias todo-parte.         
             */
        static void Main(string[] args)
        {
            // Desenvolvedores
            var pestagiário = new Developer("José", 900);
            var pJunior = new Developer("Pedro", 3000);
            var pSenior= new Developer("Douglas", 15000);

            //Gerentes
            var g3 = new Manager("João", 25000);
            var g2 = new Manager("Maria", 20000);
            var g1 = new Manager("Carlos", 15000);


            // Montar estrutura em árvores


            // Carlos supervisiona os programadores José e Pedro
            g1.add(pestagiário);
            g1.add(pJunior);

            //Maria irá supervisionar o programador Douglas
            g2.add(pSenior);

            // João irá supervisionar todos, ele é a raiz da estrutura árvore;
            g3.add(g1);
            g3.add(g2);


            g3.print();

        }
    }
}
