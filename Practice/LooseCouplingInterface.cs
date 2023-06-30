using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    public class LooseCouplingInterface
    {
        public interface ILogger
        {
            void Log(string message);   
        }

        public class ConsoleLogger: ILogger
        {
            public void Log(string message)
            {
                Console.WriteLine("Logging to console: " + message);
            }
        }

        public class FileLogger: ILogger
        {
            public void Log(string message)
            {
                Console.WriteLine("Logging to file: " + message);
            }
        }

        public class UserProcessor
        {
            public ILogger logger;
            public UserProcessor(ILogger _logger)
            {
                this.logger = _logger;
            }
            public void ProcessUser(string username)
            {
                logger.Log("User processed: " + username);
            }
        }

        //public class Program
        //{
        //    public static void Main()
        //    {
        //        UserProcessor up = new UserProcessor(new ConsoleLogger());
        //        up.ProcessUser("Jyeming");

        //        UserProcessor down = new UserProcessor(new FileLogger());
        //        down.ProcessUser("Zhunyee");
        //    }
        //}
    }
}
