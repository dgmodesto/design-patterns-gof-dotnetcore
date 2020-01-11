using System;
using System.Collections.Generic;
using System.Text;

namespace Visitor
{
    public class Fogao : Equipamento
    {
        public Fogao(string nome, double preco) : base(nome, preco)
        {
        }

        public override void accept(EquipamentoVisitor equipamento)
        {
            equipamento.visitFogao(this);
        }
    }
}
