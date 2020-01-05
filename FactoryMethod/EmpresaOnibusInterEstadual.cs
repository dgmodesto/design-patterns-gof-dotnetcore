using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    // Fabrica concreta
    public class EmpresaOnibusInterEstadual : Empresa
    {
        public override Passagem emitePassagem(string origem, string destino, DateTime dataHoraPartida)
        {
            return new PassagemOnibusInterEstadual(origem, destino, dataHoraPartida);
        }
    }
}
