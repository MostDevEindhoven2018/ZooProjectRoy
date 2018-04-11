using System;
using System.Collections.Generic;
using System.Text;
using ZooProject.Animals;

namespace ZooProject
{
    class Zoo
    {
        private List<Animal> _animals = new List<Animal>();


        public void PopulateZoo()
        {            
            _animals.Add(new Rabbit(2));
            _animals.Add(new Rabbit(5));
            _animals.Add(new Trex());
            _animals.Add(new Trump());
            _animals.Add(new Trex());       
        }

        public void PrintInfo()
        {
            foreach (Animal animal in _animals)
            {
                if (animal is Mammal)
                {
                    Console.WriteLine($"It's a {animal.AnimalType} and it says: '{animal.Sound}'");
                    Console.WriteLine($"It has {animal.AmountOfLegs} legs");
                }
                if (animal is Reptile r)
                {
                    Console.WriteLine($"It's a {animal.AnimalType} and it says: '{animal.Sound}'");
                    Console.WriteLine($"It's has laid {r.AmountOfeggs} eggs");
                }
            }
        }

        public void FeedingTime()
        {
            foreach (Animal animal in _animals)
            {
                if (animal is IHerbivore herbivore)
                {
                     while (herbivore.EatGrass()) ;
                }
                if (animal is ICarnivore carnivore)
                {
                    _animals.Find(target => target.AnimalType.Contains("Trump"));
                    carnivore.EatMeat();
                }
            }
        }
    }
}
