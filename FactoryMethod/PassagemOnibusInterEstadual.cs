using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    // Produto Concreto
    public class PassagemOnibusInterEstadual : Passagem
    {
        public PassagemOnibusInterEstadual(string origem, string destino, DateTime dataHoraPartida) 
            : base(origem, destino, dataHoraPartida)
        {
        }

        public override string exibeDetalhe()
        {
            return $"Passagem de ônibus interestadual: { this.Origem } para { this.Destino }, Data/Hora: { this.DataHoraPartida.ToString("dd/MM/yyyy HH:mm") }";
        }
    }
}
