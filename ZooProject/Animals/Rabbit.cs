using System;
using System.Collections.Generic;
using System.Text;

namespace ZooProject.Animals
{
    public class Rabbit : Mammal, IHerbivore
    {
        public Rabbit(int food) : base()
        {
            AnimalType = "Rabbit";
            Sound = "Hello I am a magical Rabbit that speaks English";
            AmountOfLegs = 4;
            Food = food;
        }
    }
}
