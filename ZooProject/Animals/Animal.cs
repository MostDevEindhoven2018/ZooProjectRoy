using System;
using System.Collections.Generic;
using System.Text;

namespace ZooProject.Animals
{
    public abstract class Animal
    {
        public string AnimalType { get; set; }
        public int AmountOfLegs { get; set; }
        public int Food { get; set; }
        public string Sound { get; set; }
        

        public bool EatGrass()
        {
            if (Food > 0)
            {
                Food -= 1;
                Console.WriteLine($"The {AnimalType} Eats some grass. Only {Food} patches left!");
                return true;
            }
            else
            {
                Console.WriteLine($"The {AnimalType} has no more food and is very sad ;(");
                return false;
            }
        }

        public void EatMeat()
        {
            if (Food > 0)
            {
                Food -= 1;
                Console.WriteLine($"The {AnimalType} Eats some meat. Only {Food} pieces left!");
            }
            else
            {
                Console.WriteLine($"The {AnimalType} has no more food and is hungry");

                //find first herbivore in list _animals, print that it gets eaten and remove it from list
                
                Console.WriteLine($"The {AnimalType} Eats a ");                               
            }
        }
    }
}
