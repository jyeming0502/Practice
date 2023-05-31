using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    public class InterfaceExercise
    {
        public interface IVehiculo
        {
            void Drive();
            bool Refuel(int gasolineAmount);
        }

        public class Car : IVehiculo
        {
            public int Fuel;

            public Car(int fuel)
            {
                Fuel = fuel;
            }

            public void Drive()
            {
                if (Fuel > 0)
                {
                    Console.WriteLine("The car is driving");
                }
            }

            public bool Refuel(int gasolineAmount)
            {
                Fuel += gasolineAmount;
                return true;
            }
        }

        //public class Program
        //{
        //    public static void Main(string[] args)
        //    {
        //        Car myCar = new Car(0);
        //        Console.WriteLine("Amount of fuel to refuel: ");
        //        int fuel = int.Parse(Console.ReadLine());
        //        if (myCar.Refuel(fuel))
        //        {
        //            myCar.Drive();
        //        }
        //    }
        //}

    }
   
}
