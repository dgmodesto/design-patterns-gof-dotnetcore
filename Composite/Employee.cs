using System;
using System.Collections.Generic;
using System.Text;

namespace Composite
{
    public abstract class Employee
    {
        protected string nome;
        protected double salario;

        public Employee(string nome, double salario)
        {
            this.nome = nome;
            this.salario = salario;
        }

        public abstract void print();
        public abstract void add(Employee e);
        public abstract void remove(Employee e);


    }
}
