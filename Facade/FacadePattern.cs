using System;
using System.Collections.Generic;
using System.Text;

namespace Facade
{
    public class FacadePattern
    {
        private SubsistemaUm sis1;
        private SubsistemaDois sis2;
        private SubsistemaTres sis3;

        public FacadePattern()
        {
            sis1 = new SubsistemaUm();
            sis2 = new SubsistemaDois();
            sis3 = new SubsistemaTres();
        }

        public void MethodA()
        {
            sis1.metodoUm();
            sis2.metodoDois();
            sis3.metodoTres();
        }

        public void MethodB()
        {
            sis3.metodoTres();
            sis2.metodoDois();
            sis1.metodoUm();
        }


    }
}
