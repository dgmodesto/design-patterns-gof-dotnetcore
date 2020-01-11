using System;
using System.Collections.Generic;
using System.Text;

namespace Visitor
{
    public abstract class Equipamento
    {
        public string nome { get; set; }
        public double preco { get; set; }

        public Equipamento(string nome, double preco)
        {
            this.nome = nome;
            this.preco = preco;
        }

        public abstract void accept(EquipamentoVisitor equipamento);
    }
}
