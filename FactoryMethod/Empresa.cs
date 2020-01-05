using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    // Fábrica abstrata
    public abstract class Empresa
    {
        public abstract Passagem emitePassagem(string origem, string destino, DateTime dataHoraPartida);
    }
}
