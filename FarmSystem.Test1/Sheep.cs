using System;

namespace FarmSystem.Test1
{
    public class Sheep : Animal
    {
       
        public void Enter(object obj)
        {
            Console.WriteLine("Sheep has entered the Emydex farm");
        }

        public override void Talk()
        {
            Console.WriteLine("Sheep says baa!");
        }
        
        public void Run()
        {
            Console.WriteLine("Sheep is running");
        }
    }

}