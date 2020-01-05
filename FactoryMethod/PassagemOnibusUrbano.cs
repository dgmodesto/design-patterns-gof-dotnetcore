using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    // Produto Concreto
    class PassagemOnibusUrbano : Passagem
    {
        public PassagemOnibusUrbano(string origem, string destino, DateTime dataHoraPartida)
            : base(origem, destino, dataHoraPartida)
        {
        }

        public override string exibeDetalhe()
        {
            return $"Passagem de ônibus Urbano: { this.Origem } para { this.Destino }, Data/Hora: { this.DataHoraPartida.ToString("dd/MM/yyyy HH:mm") }";
        }
    }
}
