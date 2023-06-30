using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    public class DependencyInversion
    {
        public class Student
        {
            public int StudentId { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }

            public DateTime DOB { get; set; }

            private IStudentRepository _student;

            public Student(IStudentRepository _studentRepo)
            {
                _student = _studentRepo;
            }
            public void Save()
            {
                _student.AddStudent();
            }
        }

        public interface IStudentRepository
        {
            void AddStudent();
            void DeleteStudent();
            void EditStudent();            
        }

        public class StudentRepository: IStudentRepository
        {
            public void AddStudent()
            {
                Console.WriteLine("Add student");
            }

            public void DeleteStudent()
            {
                Console.WriteLine("Delete student");
            }
            public void EditStudent()
            {
                Console.WriteLine("Edit student");
            }
        }

        public class RepositoryFactory
        {
            public static IStudentRepository GetStudentRepository()
            {
                return new StudentRepository(); // return new objectType(). This object must implement the interface
            }
            public static IXX GetXX()
            {
                return new Test();
            }

        }

        public interface IXX
        {
            void TestTest();
        }
        public class Test: IXX
        {
           public void TestTest()
           {
                Console.WriteLine("TestOnly");
           }
        }

        //public class Program
        //{
        //    public static void Main(string[] args)
        //    {
        //        //Student stu1 = new Student(RepositoryFactory.GetStudentRepository());
        //        //Student stu2 = new Student(RepositoryFactory.GetXX()); // will have error because the parameter passed to Student is IStudentRepository. So you cannot pass in anything other than IStudentRepository. 
        //        Student s1 = new Student(new StudentRepository());
        //        s1.Save();
        //    }
        //}

    }
}
