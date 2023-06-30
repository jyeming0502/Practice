using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    public class Adapter
    {
        public class Food
        {          
            public string Name { get; set; }

            public Food(string name)
            {
                Name = name;
            }
        }      

        // this is adaptee
        // it contains the method ProcessFood() required by the client. 
        // but it is incompatible with client code.
        public class ThirdPartyFoodSystem
        {
            public void ProcessFood(List<Food>foodList)
            {
                foreach(Food food in foodList)
                {
                    Console.WriteLine("This is: " + food.Name);
                }
            }
        }

        public interface IAdapter
        {
            void ProcessFoodFood(string[] foodArray);
        }

        public class FoodAdapter: IAdapter
        {
            // reference to the adaptee object. We are using object adapter design pattern.
            ThirdPartyFoodSystem thirdPartyFood = new ThirdPartyFoodSystem(); 

            public void ProcessFoodFood(string[] foodArray)
            {
                List<Food> foodList = new List<Food>();
                foreach(string food in foodArray)
                {
                    Food myFood = new Food(food);
                    foodList.Add(myFood);
                }
                // using the reference above, we can call the adaptee methods.
                thirdPartyFood.ProcessFood(foodList);
            }           
        }

        //public class Program
        //{
        //    public static void Main(string[] args)
        //    {
        //        string[] foodArrayList = new string[5] { "Laksa", "Cendol", "Burger", "Tomyam mee", "Ais Kacang" };
        //        IAdapter adapter = new FoodAdapter();
        //        adapter.ProcessFoodFood(foodArrayList);
        //    }
        //}
    }
}
