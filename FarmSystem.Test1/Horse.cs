using System;

namespace FarmSystem.Test1
{
    public class Horse : Animal
    {
        public void Enter(object obj)
        {
            Console.WriteLine("Horse has entered the Emydex farm");
        }

        public override void Talk()
        {
            Console.WriteLine("Horse says neigh!");
        }

        public void Run()
        {
            Console.WriteLine("Horse is running");
        }
        
    }
}