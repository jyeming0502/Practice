using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    public class AbstractClass
    {
        public abstract class Animal
        {
            public string Name { get; set; }

            public void SetName(string name)
            {
                Name = name;    
            }
            public string GetName()
            {
                return Name;
            }
            public abstract void Eat();

            public void TestTest()
            {
                Console.WriteLine("For testing purpose only");
            }
        }

        public class Dog: Animal
        {
            public override void Eat()
            {
                Console.WriteLine("The dog is eating");
            }
        }

        //public class Program
        //{
        //    public static void Main()
        //    {
        //        Console.WriteLine("Please input a dog name: ");
        //        string dogName = Console.ReadLine();

        //        Dog myDog = new Dog();
        //        myDog.SetName(dogName);
        //        Console.WriteLine(myDog.GetName());
        //        myDog.Eat();
        //        myDog.TestTest();
        //    }
        //}

    }
}
