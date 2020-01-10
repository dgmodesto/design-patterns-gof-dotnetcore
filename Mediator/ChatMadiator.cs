using System;
using System.Collections.Generic;
using System.Text;

namespace Mediator
{
    public class ChatMadiator : MediatorPattern
    {
        private Dictionary<string, Participante> participantes = new Dictionary<string, Participante>();
        private List<string> palavrasProibidas = new List<string>();

        public ChatMadiator()
        {
            setPalavrasProibidas();
        }

        private void setPalavrasProibidas()
        {
            // Carrega lista de palavras proibidas no chat
            palavrasProibidas.Add("xxxx");
            palavrasProibidas.Add("@!xxx");
            palavrasProibidas.Add("###@");
            palavrasProibidas.Add("@#$");
        }

        public void registraParticipante(Participante p)
        {
            // Verifica se não existem dois participantes com o mesmo apelido na sala de chat
            if(!participantes.ContainsKey(p.Nome))
            {
                participantes.Add(p.Nome, p);
            }
            else
            {
                Console.WriteLine("Usuários Já cadastrado na sala");
            }
        }

        public override void enviaMensagem(string remetente, string destinatario, string mensagem)
        {
            // Verifica se o remetente e o destinatário estão na sala de chat
            if (peopleAreInRoom(remetente, destinatario))
            {
                // Obtem o usuario remetente
                Participante pRemetente = participantes[remetente];
                // Obtem o usuario destinatário
                Participante pDestinatario= participantes[destinatario];

                //Verifica se a mensagem contém palavras proibidas
                palavrasProibidas.ForEach(proibido =>
                {
                    if(mensagem.Contains(proibido))
                    {
                        pRemetente.recebeMensagem("Mediator", "Você escreveu uma mensagem contendo palavras proibidas");
                        return;
                    }
                });

                // Se não há palavras proibidas na mensagem, então ela é enviada ao destinatário
                pDestinatario.recebeMensagem(remetente, mensagem);
            }
        }

        private bool peopleAreInRoom(string remetente, string destinatario)
        {
            if (participantes.ContainsKey(remetente) && participantes.ContainsKey(destinatario))
            {
                return true;
            } else
            {
                return false;
            }
        }
    }
}
