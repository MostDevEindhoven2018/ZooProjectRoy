using System;
using System.Collections.Generic;
using System.Text;

namespace ZooProject.Animals
{
    public class Trex : Reptile
    {
        public Trex() : base()
        {
            AnimalType = "Trex";
            Sound = "ROOAAARRR!!";
            AmountOfeggs = 3;
            Food = 3;
        }
    }
}
