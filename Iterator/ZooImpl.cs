using System;
using System.Collections.Generic;
using System.Text;

namespace Iterator
{
    public class ZooImpl : Zoo
    {
        private List<Animal> animals = new List<Animal>();

        public override void addAnimal(Animal animal)
        {
            animals.Add(animal);
        }

        public override IEnumerator<Animal> createIterator()
        {
            return animals.GetEnumerator();
        }

        public override List<Animal> GetAnimals()
        {
            return animals;
        }

        public override void removeAnimal(Animal animal)
        {
            animals.Remove(animal);
        }
    }
}
