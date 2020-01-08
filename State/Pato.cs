using System;
using System.Collections.Generic;
using System.Text;

namespace State
{
    public class Pato : Ave
    {
        private Comportamento comportamentoVoar;
        private Comportamento comportamentoGrasnar;

        public Pato()
        {
            comportamentoVoar = new Voar();
            comportamentoGrasnar = new Grasnar();
        }

        public override void grasnar()
        {
            comportamentoGrasnar.exec();
        }

        public override void setComportamentoGrasnar(Comportamento c)
        {
            comportamentoGrasnar = c;
        }

        public override void setComportamentoVoar(Comportamento c)
        {
            comportamentoVoar = c;
        }

        public override void voar()
        {
            comportamentoVoar.exec();
        }
    }
}
