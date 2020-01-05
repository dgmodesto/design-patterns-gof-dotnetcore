using System;

namespace Bridge
{
    class Program
    {
        /*
         - INTENÇÃO: desacoplar uma abstração da sua implementação, de modo que as duas possam variar independentemente.
         - Separa a interface do objeto de sua implementação.
             */
        static void Main(string[] args)
        {
            Professor grad = new ProfessorGraduacao(new ProfessorImplGraduacao());
            grad.op();

        }
    }
}
