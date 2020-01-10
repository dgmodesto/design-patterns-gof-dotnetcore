using System;

namespace Iterator
{
    class Program
    {
        /*
        - INTENÇÃO: fornecer um meio de acessar, sequencialmente, os elementos de um objeto agregado sem
                    expor a sua representação.
             */
        static void Main(string[] args)
        {
            // criar objeto zoo
            Zoo zoo = new ZooImpl();

            // Adiciona animais ao zoológico
            zoo.addAnimal(new Animal("Tigre", "mamifero"));
            zoo.addAnimal(new Animal("Leão", "mamifero"));
            zoo.addAnimal(new Animal("Macaco", "mamifero"));
            zoo.addAnimal(new Animal("Urso", "mamifero"));
            zoo.addAnimal(new Animal("Gavião", "ave"));
            zoo.addAnimal(new Animal("pinguin", "ave"));
            zoo.addAnimal(new Animal("arara azul", "ave"));

            MamiferoIterator it = new MamiferoIterator(zoo);

            while (it.MoveNext())
            {
                if (it.Current == null)
                    break;

                Console.WriteLine(it.Current.nome);
            }


            AveIterator itAve = new AveIterator(zoo);
            while (itAve.MoveNext())
            {
                if (itAve.Current == null)
                    break;

                Console.WriteLine(itAve.Current.nome);
            }
        }
    }
}
