using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    public class OpenClosedPrinciple
    {
        public abstract class Course
        {
            public int Id { get; set; }
            public string Name { get; set; }

            public abstract void Subscribe();
        }

        public class OnlineCourse: Course
        {
            public override void Subscribe()
            {
                Console.WriteLine("You've subscribed to the online course");
            }
        }

        public class OfflineCourse : Course
        {
            public override void Subscribe()
            {
                Console.WriteLine("You've subscribed to the offline course");
            }
        }

        //public class Program
        //{
        //    public static void Main(string[] args)
        //    {
        //        OnlineCourse onCourse = new OnlineCourse() { Name = "Software Engineering" };
        //        onCourse.Subscribe();

        //        OfflineCourse  offCourse = new OfflineCourse();
        //    }
        //}
    }
}
