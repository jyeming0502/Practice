using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    public class InheritanceObject
    {
        public class Person
        {
            public string Name { get; set; }

            public Person(string name)
            {
                this.Name = name;
            }

            public override string ToString()
            {
                return "My name is " + Name;
            }
        }

        public class Student: Person
        {
           public Student(string name): base(name)
           {

           }

            public void Study()
            {
                Console.WriteLine("Study");
            }
        }

        public class Teacher: Person
        {
            public Teacher(string name): base(name)
            {

            }

            public void Explain()
            {
                Console.WriteLine("Explain");
            }
        }

        //public class Program
        //{
        //    public static void Main()
        //    {
        //        string[] names = new string[3];
        //        for (int i = 0; i < 3; i++)
        //        {
        //            Console.WriteLine("Please input 3 names: ");
        //            names[i] = Console.ReadLine();
        //        }
        //        Person _person = new Person(names.ToString());
        //    }
        //}
    }
}
