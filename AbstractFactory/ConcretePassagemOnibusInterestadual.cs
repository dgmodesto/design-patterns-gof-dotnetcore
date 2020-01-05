using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    public class ConcretePassagemOnibusInterestadual : PassagemOnibusInterestadual
    {
        public ConcretePassagemOnibusInterestadual(string origem, string destino, DateTime dataHoraPartida) 
            : base(origem, destino, dataHoraPartida)
        {
        }

        public override string exibeDetalhe()
        {
            return $"Passagem de ônibus interestadual: { this.Origem } para { this.Destino }, Data/Hora: { this.DataHoraPartida.ToString("dd/MM/yyyy HH:mm") }";
        }
    }
}
