using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    public class SingleResponsibility
    {
       public interface ILogger
        {
            void Log(string message);
        }

        public class Student
        {
            ILogger logger;
            public int Id { get; set; }
            public string FirstName { get; set; }   
            public string LastName { get; set; }    
            public string Email { get; set; }

            public Student(ILogger logger)
            {
                this.logger = logger;
            }

            public void Save()
            {
                logger.Log("Save student data");
            }

            public void Delete()
            {
                logger.Log("Delete student data");
            }

        }

        
        public class LogMessage: ILogger
        {
            public void Log(string message)
            {
                Console.WriteLine("We received the log for:" + message);
            }
        }

        //public class Program
        //{
        //    public static void Main(string[] args)
        //    {
        //        Student myStudent = new Student(new LogMessage());
        //        myStudent.Save();
        //        myStudent.Delete();
        //    }
        //}
    }
}
