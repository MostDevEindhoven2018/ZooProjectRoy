using System;
using System.Collections.Generic;
using System.Text;

namespace ZooProject.Animals
{
    public class Trump : Mammal, IHerbivore
    {
        public Trump() : base()
        {
            AnimalType = "Trump";
            Sound = "I live in the best zoo in the world! It's great! It has the best walls!";
            AmountOfLegs = 2;
            Food = 2;
        }
    }
}
