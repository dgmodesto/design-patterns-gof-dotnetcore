using System;
using System.Collections.Generic;
using System.Text;

namespace Mediator
{
    public abstract class Participante
    {
        private string nome;

        public string Nome
        {
            get { return nome; }
            private set { nome = value; }
        }


        private MediatorPattern mediator;
        public MediatorPattern Mediator
        {
            get { return mediator; }
            private set { mediator = value; }
        }


        public Participante(string nome, MediatorPattern mediator)
        {
            this.nome = nome;
            this.Mediator = mediator;
        }

        public void setNome(string nome)
        {
            this.Nome = nome;
        }

        public void setMediator(MediatorPattern mediator)
        {
            this.Mediator = mediator;
        }

        public abstract void enviarMensagem(string destinatario, string mensagem);

        public abstract void recebeMensagem(string remetente, string mensagem);

    }
}
