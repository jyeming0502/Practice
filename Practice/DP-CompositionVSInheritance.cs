using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    public class DP_CompositionVSInheritance
    {
        public class ClassA
        {
            public void Foo()
            {

            }
            public virtual int Bar()
            {
                return 5;
            }
        }

        //public class ClassB: ClassA
        //{
        //    public override int Bar()
        //    {
        //        return 5;
        //    }
        //}

        public class ClassB
        {
            ClassA classA = new ClassA();
            public void test()
            {
                classA.Foo();
                classA.Bar();
            }
        }

        public class Program
        {
            public static void Main()
            {
                ClassB classB = new ClassB();
                classB.test();
            }
        }

    }
}
