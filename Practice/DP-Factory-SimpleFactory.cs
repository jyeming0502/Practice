using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    public class Factory_SimpleFactory
    {
        public interface IProduct
        {
            void Operation();
        }

        public class ConcreteProductA : IProduct
        {
            public void Operation()
            {
                Console.WriteLine("Operation for Concrete Product A");
            }
        }

        public class ConcreteProductB : IProduct
        {
            public void Operation()
            {
                Console.WriteLine("Operation for Concrete Product A");
            }
        }

        // uses SimpleFactory class to create object based on a parameter. 
        public class SimpleFactory
        {
            public static IProduct CreateProduct(string type)
            {
                switch (type)
                {
                    case "A":
                        return new ConcreteProductA();
                    case "B":
                        return new ConcreteProductB();
                    default:
                        throw new ArgumentException("Invalid product type");
                }
            }
        }

        //public class Client
        //{
        //    public IProduct _product;
        //    public Client(SimpleFactory product, string type)
        //    {
        //        _product = product.CreateProduct(type);
        //    }
        //    public void ExecuteOperation() 
        //    {
        //        _product.Operation();
        //    }
        //}
        public class Program
        {
            public static void Main(string[] args)
            {
                //SimpleFactory _factory = new SimpleFactory();
                //Client newClient = new Client(_factory, "A");
                //newClient.ExecuteOperation();
                IProduct _pro = SimpleFactory.CreateProduct("A");
                _pro.Operation();
            }
        }

    }
}
