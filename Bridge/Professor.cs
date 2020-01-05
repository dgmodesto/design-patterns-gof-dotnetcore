using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge
{
    public abstract class Professor
    {
        protected Implementador imp = new ProfessorImplGraduacao();

        public Professor(Implementador imp)
        {
            this.imp = imp;
        }



        public abstract void op();
    }
}
