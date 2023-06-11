using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    public  class TightlyLooselyCoupled
    {
        public interface OutputGenerator
        {
            public void GenerateOutput();
        }

        public class CSVOutputGenerator: OutputGenerator
        {
            public void GenerateOutput()
            {
                Console.WriteLine("CSV Output Generator");
            }
        }

        public class JSONOutputGenerator: OutputGenerator
        {
            public void GenerateOutput()
            {
                Console.WriteLine("JSON Output Generator");
            }
        }
    }

    public class Class1
    {
        public class Engine
        {

        }
        private Engine engine;
        public Class1(Engine engine)
        {
            this.engine = engine;
        }
    }
}
