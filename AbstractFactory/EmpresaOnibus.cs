using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    public abstract class EmpresaOnibus
    {
        public abstract ConcretePassagemOnibusUrbano emitePassagemOnibusUrbano(string origem, string destino, DateTime dataHoraPartida);
        public abstract ConcretePassagemOnibusInterestadual emitePassagemOnibusInterestadual(string origem, string destino, DateTime dataHoraPartida);
    }
}
