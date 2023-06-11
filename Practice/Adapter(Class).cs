using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    public class Adapter_Class_
    {
        public class Food
        {
            public string Name { get; set; }

            public Food(string name)
            {
                Name = name;
            }
        }

        public class ThirdPartyFoodSystem
        {
            public void ProcessFood(List<Food> foodList)
            {
                foreach (Food food in foodList)
                {
                    Console.WriteLine("This is: " + food.Name);
                }
            }
        }

        public interface IAdapter
        {
            void ProcessFoodFood(string[] foodArray);
        }

        public class FoodAdapter: ThirdPartyFoodSystem, IAdapter
        {
            public void ProcessFoodFood(string[] foodArray)
            {
                List<Food> foodList = new List<Food>();
                foreach (string food in foodArray)
                {
                    Food myFood = new Food(food);
                    foodList.Add(myFood);
                }
                ProcessFood(foodList);
            }
        }

        //public class Program
        //{
        //    public static void Main(string[] args)
        //    {
        //        string[] foodArrayArray = new string[5] { "Laksa", "Cendol", "Burger", "Tomyam mee", "Ais Kacang" };
        //        IAdapter foodAdapter = new FoodAdapter();
        //        foodAdapter.ProcessFoodFood(foodArrayArray);
        //    }
        //}

    }
}
