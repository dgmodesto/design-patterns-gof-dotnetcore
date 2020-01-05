using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    // Fábrica concreta
    public class EmpresaOnibusUrbano : Empresa
    {
        public override Passagem emitePassagem(string origem, string destino, DateTime dataHoraPartida)
        {
            return new PassagemOnibusUrbano(origem, destino, dataHoraPartida);
        }
    }
}
