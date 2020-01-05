using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    public class ConcreteEmpresaOnibus : EmpresaOnibus
    {
        public override ConcretePassagemOnibusInterestadual emitePassagemOnibusInterestadual(string origem, string destino, DateTime dataHoraPartida)
        {
            return new ConcretePassagemOnibusInterestadual(origem, destino, dataHoraPartida);
        }

        public override ConcretePassagemOnibusUrbano emitePassagemOnibusUrbano(string origem, string destino, DateTime dataHoraPartida)
        {
            return new ConcretePassagemOnibusUrbano(origem, destino, dataHoraPartida);
        }
    }
}
