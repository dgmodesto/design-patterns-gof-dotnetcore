﻿using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    public abstract class PassagemOnibusInterestadual
    {
        private string origem;
        public string Origem
        {
            get { return origem; }
            private set { origem = value; }
        }


        private string destino;
        public string Destino
        {
            get { return destino; }
            private set { destino = value; }
        }

        private DateTime dataHoraPartida;

        public DateTime DataHoraPartida
        {
            get { return dataHoraPartida; }
            private set { dataHoraPartida = value; }
        }

        public PassagemOnibusInterestadual(string origem, string destino, DateTime dataHoraPartida)
        {
            this.origem = origem;
            this.destino = destino;
            this.dataHoraPartida = dataHoraPartida;
        }

        public abstract string exibeDetalhe();
    }
}
