using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge
{
    public class ProfessorImplGraduacao : Implementador
    {
        public override void opImpl()
        {
            Console.WriteLine("Implementação Prof. Graduação");
            Console.WriteLine("Tchau");
        }
    }
}
