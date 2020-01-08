using System;

namespace State
{
    class Program
    {
        /*
        - INTENÇÃO: permite a um objeto alterar seu comportamento quando o seu estado interno muda.
                    O objeto parecerá ter mudado sua classe
        - Alterar o comportamento de um objeto quando seu estado muda.
             */
        static void Main(string[] args)
        {
            Pato p = new Pato();
            p.voar();
            p.grasnar();

            // alterando o comportamento da classe pato.
            p.setComportamentoVoar(new NaoVoar());
            p.setComportamentoGrasnar(new NaoGrasnar());
            p.voar();
            p.grasnar();

        }
    }
}
