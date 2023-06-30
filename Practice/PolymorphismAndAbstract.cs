using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    public class PolymorphismAndAbstract
    {
        public class Shape
        {
            protected int width, height;
            public Shape(int a = 0, int b = 0)
            {
                width = a;
                height = b;
            }
            public virtual int Area()
            {
                Console.WriteLine("Parent class area");
                return 0;
            }
        }
        public class Rectangle: Shape
        {
            // we must declare base with width and height parameter
            // because when we pass in parameter value to Rectangle
            // the parameter value also will pass to base
            // and the value pass to base will call the Shape constructor
            // and the value will be used as the width and height in the constructor
            // when we call the Area(), it will return the width and height value. 
            public Rectangle(int width = 0, int height = 0): base(width, height) { } 
            public override int Area()
            {
                Console.WriteLine("Rectangle class area: ");
                return width * height;
            }
        }
        public class Triangle: Shape
        {
            public Triangle(int width = 0, int height = 0): base(width, height) { }
            public override int Area()
            {
                Console.WriteLine("Triangle class area: ");
                return width * height;
            }
        }

        public class Caller
        {
            public void CallArea(Shape s)
            {
                int area = s.Area();
                Console.WriteLine("Area: {0} ", area);
            }
        }
        //public class Program
        //{
        //    public static void Main()
        //    {
        //        Rectangle r = new Rectangle(10, 4); 
        //        Triangle t = new Triangle(3, 3);

        //        Caller c = new Caller();
        //        c.CallArea(r); 
        //        c.CallArea(t);
        //    }
        //}
    }
}
