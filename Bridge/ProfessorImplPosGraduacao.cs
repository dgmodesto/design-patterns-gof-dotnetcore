using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge
{
    public class ProfessorImplPosGraduacao : Professor
    {
        public ProfessorImplPosGraduacao(Implementador imp) : base(imp)
        {
        }

        public override void op()
        {
            imp.opImpl();
        }

    
    }
}
