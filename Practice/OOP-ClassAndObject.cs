using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    public class ClassAndObject
    {
        public class Person
        {
            public int Age { get; set; }
            public void Greet()
            {
                Console.WriteLine("Hello");
            }
            public void SetAge(int age)
            {
                Age = age;
            }
        }
        
        public class Student: Person
        {
            public void Study()
            {
                Console.WriteLine("I'm studying");
            }
            public void ShowAge()
            {
                Console.WriteLine("My age is: {0}", Age, "years old");
            }
        }

        public class Teacher: Person
        {
            public void Explain()
            {
                Console.WriteLine("I'm explaining");
            }
        }

        //public class StudentProfessorTest
        //{
        //    public static void Main()
        //    {
        //        Person person = new Person();
        //        person.Greet();

        //        Student student = new Student();
        //        student.SetAge(16);
        //        student.Greet();
        //        student.ShowAge();
        //        student.Study();

        //        Teacher teacher = new Teacher();
        //        teacher.SetAge(35);
        //        teacher.Greet();
        //        teacher.Explain();
        //    }
        //}
    }
}
