using FarmSystem.Test2;
using System;
using System.Collections.Generic;

namespace FarmSystem.Test1
{
    public class EmydexFarmSystem
    {
        Queue<Animal> animal_queue = new Queue <Animal>();
        public event EventHandler<EventArgs> NotifyFarmEmpty;
        //TEST 1
        public void Enter(object animal)
        {
            //TODO Modify the code so that we can display the type of animal (cow, sheep etc) 
            //Hold all the animals so it is available for future activities
            Animal a = (Animal)animal;
            animal_queue.Enqueue(a);

            Console.WriteLine(animal.GetType().Name +" has entered the farm");
        }
     
        //TEST 2
        public void MakeNoise()
        {
            //Test 2 : Modify this method to make the animals talk
            foreach(var ele in animal_queue)
            {
                ele.Talk();
            }  
        }

        //TEST 3
        public void MilkAnimals()
        {
            foreach (var ele in animal_queue)
            {
                //if (ele.GetType().Name == "Cow")
                if(ele is IMilkableAnimal a)
                {
                    a.Milked();
                }
            }
        }

        //TEST 4
        public void ReleaseAllAnimals()
        {
            var size = animal_queue.Count;
            for (var i= 0;i<size ;i++)
            {
               var x= animal_queue.Dequeue();
               Console.WriteLine(x.GetType().Name + " has left the farm");
            }

            // Dequeue Has cleared the contents of the collection

            NotifyFarmEmpty?.Invoke(this, new EventArgs());

            // Console.WriteLine("There are still animals in the farm, farm is not free");
        }
    }
}