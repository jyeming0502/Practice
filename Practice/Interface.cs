using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    public interface IAllEmployee
    {
        public int CalculateSalary();
    }

    public class Employee
    {
        public virtual int CalculateBonus()
        {
            return 10000;
        }
    }

    public class PermanentEmployee: Employee, IAllEmployee
    {
        public int CalculateSalary()
        {
            return 5000;
        }

        public override int CalculateBonus()
        {
            return 10000;
        }
    }

    public class ContractualEmployee: IAllEmployee
    {
        public int CalculateSalary()
        {
            return 15000;
        }
    }

    //public class Program
    //{
    //    public static void Main(string[] args)
    //    {
    //        PermanentEmployee pe = new PermanentEmployee();

    //    }
    //}

    
}
