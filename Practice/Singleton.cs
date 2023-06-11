using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    public sealed class Singleton // sealed is to prevent inheritance
    {
        private static int Counter = 0;
        private static Singleton Instance = null;
        public static Singleton GetInstance()
        {
            if (Instance == null)
            {
                Instance = new Singleton(); // create a new Singleton() will invoke the Singleton constructor
            }
            return Instance;
        }
        // constructor is private, meaning it cannot create an instance of this class
        private Singleton()
        {
            Counter++; // increase the counter value by 1 each time the constructor is called
            Console.WriteLine("Counter Value: " + Counter);
        }

        public void PrintDetails(string message)
        {
            Console.WriteLine(message);
        }

        //public class Program
        //{
        //    public static void Main(string[] args)
        //    {
        //        Singleton singleton1 = Singleton.GetInstance();
        //        singleton1.PrintDetails("hi this is the first singleton");

        //        Singleton singleton2 = Singleton.GetInstance();
        //        singleton2.PrintDetails("hi this is the second singleton");
        //    }
        //}

    }
}
