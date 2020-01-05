using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    public class ConcretePassagemOnibusUrbano : PassagemOnibusUrbano
    {
        public ConcretePassagemOnibusUrbano(string origem, string destino, DateTime dataHoraPartida)
            : base(origem, destino, dataHoraPartida)
        {
        }

        public override string exibeDetalhe()
        {
            return $"Passagem de ônibus urbano: { this.Origem } para { this.Destino }, Data/Hora: { this.DataHoraPartida.ToString("dd/MM/yyyy HH:mm") }";
        }
    }
}
