using System;
using System.Collections.Generic;
using System.Text;

namespace Visitor
{
    public class Tv : Equipamento
    {
        public Tv(string nome, double preco) : base(nome, preco)
        {
        }

        public override void accept(EquipamentoVisitor equipamento)
        {
            equipamento.visitTv(this);

        }
    }
}
