using System;
using System.Collections.Generic;
using System.Text;

namespace Visitor
{
    public class PrecoEquipamentoVisitor : EquipamentoVisitor
    {

        public override void visitFogao(Fogao fogao)
        {
            Console.WriteLine($"Preço do fogão { fogao.nome } = $ {fogao.preco} com + 5% de impostos, total $ { fogao.preco * 1.05 }");
        }

        public override void visitGeladeira(Geladeira geladeira)
        {
            Console.WriteLine($"Preço do geladeira { geladeira.nome } = $ {geladeira.preco} com + 4% de impostos, total $ { geladeira.preco * 1.04 }");
        }

        public override void visitTv(Tv tv)
        {
            Console.WriteLine($"Preço do tv { tv.nome } = $ {tv.preco} com + 7% de impostos, total $ { tv.preco * 1.07 }");
        }
    }
}
