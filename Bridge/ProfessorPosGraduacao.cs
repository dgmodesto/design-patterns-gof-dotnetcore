using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge
{
    public class ProfessorPosGraduacao : Professor
    {
        public ProfessorPosGraduacao(Implementador imp) : base(imp)
        {
        }

        public override void op()
        {
            imp.opImpl();
        }
    }
}
