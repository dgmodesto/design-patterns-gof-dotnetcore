using System;
using System.Collections.Generic;
using System.Text;

namespace Composite
{
    // Composite
    public class Manager : Employee
    {
        protected List<Employee> listSubordinates;

        public Manager(string nome, double salario) : base(nome, salario)
        {
            listSubordinates = new List<Employee>();
        }

        // Exibe a estrutura
        public override void print()
        {
            Console.WriteLine(base.nome + ", $" + base.salario);
            listSubordinates.ForEach(e =>
            {
                e.print();
            });

        }
        // adiciona employee na estrutura
        public override void add(Employee e)
        {
            this.listSubordinates.Add(e);
        }

        // Remove employee da estrutura
        public override void remove(Employee e)
        {
            this.listSubordinates.Remove(e);
        }

    }
}
