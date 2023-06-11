using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    public class Abstraction_2
    {
        public abstract class Animal
        {
            public string animalNameee;
            public Animal(string animalName)
            {
                animalNameee = animalName;
            }
            public string Name { get; set; }
            public abstract void AnimalEat();
            public abstract void AnimalSleep();
            public abstract void AnimalDrink();
            public void CallMyAnimal()
            {
                Console.WriteLine("My animal is: " + animalNameee);
            }
        }

        public class Dog: Animal
        {
            public Dog(string animalName) : base(animalName)
            {
            }

            public override void AnimalEat()
            {
                Console.WriteLine("I eat biscuits and meat.");
            }

            public override void AnimalSleep()
            {
                Console.WriteLine("I sleep after I eat.");
            }

            public override void AnimalDrink()
            {
                Console.WriteLine("I drink 1L of water everyday.");
            }
        }

        //public class Program
        //{
        //    public static void Main(string[] args)
        //    {
        //        //Dog myDog = new Dog("Ah girl");
        //        //myDog.AnimalEat();
        //        //myDog.AnimalDrink();
        //        //myDog.AnimalSleep();
        //        //myDog.CallMyAnimal();
        //        Animal myAnimal = new Dog("Ah girl");
        //        myAnimal.AnimalEat();
        //        myAnimal.AnimalDrink();
        //        myAnimal.AnimalSleep();

        //    }
        //}

    }
}
