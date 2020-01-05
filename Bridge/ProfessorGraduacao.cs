using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge
{
    public class ProfessorGraduacao: Professor
    {
        public ProfessorGraduacao(Implementador imp) : base(imp)
        {
        }

        public override void op()
        {
            Console.WriteLine("Olá");
            imp.opImpl();
        }
    }
}
