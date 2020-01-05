using System;

namespace Prototype
{
    class Program
    {
        /*
          - INTENÇÃO: especificar os tipos de objetos a serem criados usando uma instância
                      protótipo e criar novos objetos pela cópia deste protótipo
          - Uma instância inicializada a ser copiada ou clonada
          - fazer clones de objetos
             
        */
        static void Main(string[] args)
        {
            // Carregar os diferentes tipos de notas musicais;
            Partitura.carregaNotas();

            //Compor a canção
            Partitura.getNota("Do").desenha();
            Partitura.getNota("Re").desenha();
            Partitura.getNota("Mi").desenha();
            Partitura.getNota("Fa").desenha();
            Partitura.getNota("Sol").desenha();
            Partitura.getNota("La").desenha();
            Partitura.getNota("Do").desenha();
            Partitura.getNota("Re").desenha();
            Partitura.getNota("Do").desenha();

        }
    }
}
