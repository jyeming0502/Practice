using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    public class DP_ChainOfResponsibility
    {
        public abstract class Handler
        {
            protected Handler NextHandler;
            public void SetNextHandler(Handler NextHandler)
            {
                this.NextHandler = NextHandler;
            }
            public abstract void HandleRequest(int amount);
        }        

        public class ConcreteHandler1: Handler
        {
            public override void HandleRequest(int amount)
            {
                if (amount <=100)
                {
                    Console.WriteLine("ConcreteHandler1 handles the request");
                }
                else if (NextHandler != null)
                {
                    NextHandler.HandleRequest(amount);
                }
            }

        }

        public class ConcreteHandler2: Handler
        {
            public override void HandleRequest(int amount)
            {
                if(amount > 100 && amount <= 200)
                {
                    Console.WriteLine("ConcreteHandler2 handles the request");
                }
                else if (NextHandler != null)
                {
                    NextHandler.HandleRequest(amount);
                }
            }
        }
        public class ConcreteHandler3 : Handler
        {
            public override void HandleRequest(int amount)
            {
                if (amount > 200)
                {
                    Console.WriteLine("ConcreteHandler3 handles the request");
                }
                else if (NextHandler != null)
                {
                    NextHandler.HandleRequest(amount);
                }
            }
        }
       //public class Program
       //{
       //     public static void Main()
       //     {
       //         Handler handler1 = new ConcreteHandler1();
       //         Handler handler2 = new ConcreteHandler2();
       //         Handler handler3 = new ConcreteHandler3();

       //         handler1.SetNextHandler(handler2);  
       //         handler2.SetNextHandler(handler3);

       //         handler1.HandleRequest(50);
       //         handler1.HandleRequest(300);
       //         handler1.HandleRequest(150);

       //     }
       //}
    }
}
