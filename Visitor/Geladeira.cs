using System;
using System.Collections.Generic;
using System.Text;

namespace Visitor
{
    public class Geladeira : Equipamento
    {
        public Geladeira(string nome, double preco) : base(nome, preco)
        {
        }

        public override void accept(EquipamentoVisitor equipamento)
        {
            equipamento.visitGeladeira(this);
        }
    }
}
