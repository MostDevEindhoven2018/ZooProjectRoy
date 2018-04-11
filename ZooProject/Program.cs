using System;
using System.Collections.Generic;
using ZooProject.Animals;

namespace ZooProject
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Zoo zoo = new Zoo();
            zoo.PopulateZoo();
            zoo.PrintInfo();
            zoo.FeedingTime();
            Console.ReadLine();
        }       
    }    

    

    

    

    

   
}
