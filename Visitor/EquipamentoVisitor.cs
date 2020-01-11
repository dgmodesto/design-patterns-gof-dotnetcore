using System;
using System.Collections.Generic;
using System.Text;

namespace Visitor
{
    public abstract class EquipamentoVisitor
    {
        public abstract void visitGeladeira(Geladeira geladeira);
        public abstract void visitTv(Tv tv);
        public abstract void visitFogao (Fogao fogao);
    }
}
