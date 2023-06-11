using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    public class Constructor
    {
        
        public class A
        {
            B b;
            public A()
            {
                b = new B();
            }

            public class B
            {
                public void SomeMethodB()
                {
                    Console.WriteLine("This is for B.");
                }
            }

            //public static void Main(string[] args)
            //{
            //    A myA = new A();
            //    myA.b.SomeMethodB();
            //}
        }     
        // everything above is inside class A
    }
}
