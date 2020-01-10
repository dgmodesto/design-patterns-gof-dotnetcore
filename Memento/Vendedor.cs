using System;
using System.Collections.Generic;
using System.Text;

namespace Memento
{
    public class Vendedor
    {
        public string Nome { get; set; }
        public double TotalDeVendas { get; set; }

        public Vendedor(string nome, double totalVendas)
        {
            this.Nome = nome;
            this.TotalDeVendas = totalVendas;
        }

        public Memento createMemento()
        {
            return new Memento(this.Nome, this.TotalDeVendas);
        }

        public void restoreMemento(Memento memento)
        {
            this.Nome = memento.Nome;
            this.TotalDeVendas = memento.TotalVendas;
        }
    }
}
