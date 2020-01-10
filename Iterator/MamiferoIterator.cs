using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Iterator
{
    // Concrete Iterator
    public class MamiferoIterator : IEnumerator<Animal>
    {
        private Zoo zoo { get; set; }
        private int pos = -1;

        public MamiferoIterator(Zoo zoo)
        {
            this.zoo = zoo;
        }


        object IEnumerator.Current
        {
            get
            {
                return Current;
            }
        }

        // Iteração Filtrada
        public Animal Current
        {
            get
            {

                var animals = zoo.GetAnimals();

                while (pos < animals.Count)
                {
                    if (animals[pos].classe.Equals("mamifero"))
                    {
                        return animals[pos];
                    }
                    ++pos;

                }

                return null;

            }
        }
     

        // Metodo verifica se existe um proximo elemento especifico dessa classe na lista
        public bool MoveNext()
        {
            bool returnMethod = false;

            for (int i = 0; i < zoo.GetAnimals().Count; i++)
            {
                if (zoo.GetAnimals()[i].classe.ToLower().Equals("mamifero"))
                {
                    returnMethod = true;
                    pos++;
                    break;

                }
            }
            return returnMethod;
        }

        public void Reset()
        {
            pos = -1;
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
