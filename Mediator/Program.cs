using System;

namespace Mediator
{
    class Program
    {
        /*
        - INTENÇÃO: definir um objeto que encapsula a forma como um conjunto de objetos interage.
                    O MEDIATOR  promove o acoplamento fraco ao evitar que os objetos se refiram uns aos outros explicitamente
                    e permite variar suas interações independentemente.
        - Definir uma comunicação simplificada entre as classes.
             */
        static void Main(string[] args)
        {
            // Cria-se o objeto mediator
            ChatMadiator salaChat = new ChatMadiator();

            // Cria-se os participantes
            var douglas = new ParticipanteImpl("Douglas", salaChat);
            var maria = new ParticipanteImpl("Maria", salaChat);
            var carlos = new ParticipanteImpl("Carlos", salaChat);
            var joao = new ParticipanteImpl("João", salaChat);


            // Registra todos os participantes na sala do chat
            salaChat.registraParticipante(douglas);
            salaChat.registraParticipante(maria);
            salaChat.registraParticipante(carlos);
            salaChat.registraParticipante(joao);



            // Inicia a conversa entre os participantes
            douglas.enviarMensagem("Maria", "Olá Maria, bom dia! Tudo bem?");
            maria.enviarMensagem("Douglas", "Oi, bom dia, tudo bem sim");
            carlos.enviarMensagem("João", "João é um @!xxx");
            douglas.enviarMensagem("Maria", "fortalece lá, aprova um Pull Request pra mim por favor");


        }
    }
}
