using System;
using System.Collections.Generic;
using System.Text;

namespace Composite
{
    public class Developer : Employee
    {
        public Developer(string nome, double salario) : base(nome, salario)
        {
        }

        public override void add(Employee e)
        {
            Console.WriteLine("Não é possivel adicionar empregado subordinado do programador");
        }


        public override void print()
        {
            Console.WriteLine( base.nome +  " , $" + base.salario);

        }

        public override void remove(Employee e)
        {
            Console.WriteLine("Programador não tem subordinado para ser removido");
        }
    }
}
