using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    public class PracticeOOP
    {
        public interface ILogger
        {
            void Log();
        }
        public class LoggerA: ILogger
        {
            public void Log()
            {
                Console.WriteLine("This is for Log A");
            }
        }
        public class LoggerB: ILogger
        {
            public void Log()
            {
                Console.WriteLine("This is for Log B");
            }
        }
        public class LoggerC: ILogger
        {
            public void Log()
            {
                Console.WriteLine("This is for Log C");
            }
        }

        public class SimpleFactory
        {
            public ILogger GetLoggerObject(string type)
            {
                if (type == "A")
                {
                    return new LoggerA();
                }
                else if (type == "B")
                {
                    return new LoggerB();
                }
                else return new LoggerC();                   
            }

        }

        //public class Program
        //{
        //    public static void Main(string[] args)
        //    {
        //        SimpleFactory factory = new SimpleFactory();
        //        ILogger myLogger = factory.GetLoggerObject("A");
        //        myLogger.Log();
        //    }
        //}
    }
}
