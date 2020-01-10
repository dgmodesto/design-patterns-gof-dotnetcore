using System;

namespace ChainOfResponsability
{
    class Program
    {
        /*
        - INTENÇÃO: evitar o acoplamento do remetente de uma solicitação ao seu receptor, ao dar a mais de um objeto a
                    oportunidade de tratar a solicitação. Ecadear os objetos receptores, passsando a solicitação ao longo
                    da cadeia até que um objeto a trate.
        - Uma maneira de passar uma requisição entre uma cadeia de objetos.
             */
        static void Main(string[] args)
        {
            //Tomadores de decisão

            var presidente = new Presidente();
            var vicePresidente = new VicePresidente();
            var diretor= new Diretor();
            var gerente = new Gerente();

            //Setando seus respectivos sucessores
            gerente.setSucessor(diretor);
            diretor.setSucessor(vicePresidente);
            vicePresidente.setSucessor(presidente);

            // setando o valor da compra

            // compra aprovada pelo gerente
            gerente.aprova(new Compra(100));

            // Compra aprovada pelo diretor
            gerente.aprova(new Compra(1000));

            // compra aprovada pelo vice presidente
            gerente.aprova(new Compra(10000));

            // compra aprovada pelo presidente
            gerente.aprova(new Compra(100000));

            // compra não aprovada
            gerente.aprova(new Compra(1000000));


        }
    }
}
