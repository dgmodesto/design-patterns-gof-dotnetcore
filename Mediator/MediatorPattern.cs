using System;
using System.Collections.Generic;
using System.Text;

namespace Mediator
{
    public abstract class MediatorPattern
    {
        public abstract void enviaMensagem(string remetente, string destinatario, string mensagem);
    }
}
