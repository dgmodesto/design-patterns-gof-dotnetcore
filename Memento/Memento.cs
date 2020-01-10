using System;
using System.Collections.Generic;
using System.Text;

namespace Memento
{
    public class Memento
    {
        public string Nome { get; set; }
        public double TotalVendas { get; set; }

        public Memento(string nome, double totalVendas)
        {
            Nome = nome;
            TotalVendas = totalVendas;
        }

    }
}
