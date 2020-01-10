using System;
using System.Collections.Generic;
using System.Text;

namespace Mediator
{
    public class ParticipanteImpl : Participante
    {
        public ParticipanteImpl(string nome, MediatorPattern mediator) : base(nome, mediator)
        {
        }

        public override void enviarMensagem(string destinatario, string mensagem)
        {
            MediatorPattern mediator = this.Mediator;
            mediator.enviaMensagem(this.Nome, destinatario, mensagem);
        }

        public override void recebeMensagem(string remetente, string mensagem)
        {
            Console.WriteLine(remetente + " escreveu: " + mensagem);
        }
    }
}
