using System;

namespace FarmSystem.Test1
{
    public class Hen : Animal
    {

        public  void Enter(object obj)
        {
            Console.WriteLine("Hen has entered the Emydex farm");
        }

        public  override void Talk()
        {
            Console.WriteLine("Hen say CLUCKAAAAAWWWWK!");
        }

        public void Run()
        {
            Console.WriteLine("Hen is running");
        }
    }
}