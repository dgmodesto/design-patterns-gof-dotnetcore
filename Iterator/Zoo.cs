using System;
using System.Collections.Generic;
using System.Text;

namespace Iterator
{
    public abstract class Zoo
    {
        public abstract List<Animal> GetAnimals();
        public abstract void addAnimal(Animal animal);
        public abstract void removeAnimal(Animal animal);
        public abstract IEnumerator<Animal> createIterator();
    }
}
