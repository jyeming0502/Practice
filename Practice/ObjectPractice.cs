using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    public class Sample
    {
        public int value;
        public void setValue(int setValuee)
        {
            value = setValuee;
        }
        public void printValue()
        {
            Console.WriteLine("Value: " + value);
        }

        public void AddValue(Sample s1, Sample s2)
        {
            value = s1.value + s2.value;
        }
    }

    //public class Program
    //{
    //    public static void Main(string[] args)
    //    {
    //        Sample s1 = new Sample();
    //        Sample s2 = new Sample();
    //        Sample s3 = new Sample();

    //        //s1.setValue(2);
    //        //s2.setValue(4);
    //        //s2.AddValue(s1, s2);

    //        s1.value = 5;
    //        s2.value = 6;

    //        s3.AddValue(s1, s2);
    //        s1.printValue();
    //        s2.printValue();
    //        s3.printValue();
    //    }
    //}
}
