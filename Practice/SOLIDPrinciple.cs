using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    public class Rectangle
    {
        public virtual int Height { get; set; }
        public virtual int Width { get; set; }

    }

    public class Square: Rectangle
    {
        private int _height;
        private int _width;

        public override int Height
        {
            get { return _height; }
            set { _height = value; }
        }

        public override int Width
        {
            get { return _width; }
            set { _width = value; }
        }
    }

    public class AreaCalculator
    {
        public static int CalculateArea(Square r)
        {
            return r.Width * r.Height;
        }
    }

    //public class Program
    //{
    //    public static void Main(string[] args)
    //    {
    //        Square square1 = new Square();
    //        square1.Height = 6;
    //        square1.Width = 8;

    //        Console.WriteLine(AreaCalculator.CalculateArea(square1));

    //        Square square2 = new Square();
    //        square2.Height = 8;
    //        square2.Width = 6;

    //        Console.WriteLine(AreaCalculator.CalculateArea(square2));
    //    }

    //}



}
