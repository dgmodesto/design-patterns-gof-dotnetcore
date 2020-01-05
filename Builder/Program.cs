using System;

namespace Builder
{
    class Program
    {
        /*
          - INTENÇÃO: separar a construção de um objeto complexo da sua representação de modo que o mesmo
                      processo de construção possa criar diferentes representações
          - Separa a construção do objeto de sua representação.
          - 
             */
        static void Main(string[] args)
        {
            Cozinha cozinha = new Cozinha();

            //Builders
            SanduicheBuilder b1 = new HamburgerBuilder();
            SanduicheBuilder b2 = new FishBuilder();

            cozinha.fazSanduiche(b1);
            b1.getSanduiche();

            Console.WriteLine("");
            Console.WriteLine("Próximo Pedido");
            Console.WriteLine("");


            cozinha.fazSanduiche(b2);
            b2.getSanduiche();

        }
    }
}
