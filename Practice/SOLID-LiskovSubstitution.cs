using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    public class LiskovSubstitution
    {
        public interface IGeneralEmployee
        {
            public int Salary { get; set; }
            public int Year { get; set; }
            public void CalculateSalary();
        }
        public class ExceptionalEmployee
        {
            public void CalculateBonus(int year, int salary)
            {
                int totalBonus = year * salary;
                Console.WriteLine("Your bonus is: " + totalBonus);
            }
        }
        public class PermanentEmployee: ExceptionalEmployee, IGeneralEmployee
        {
            public int Salary { get; set;}
            public int Year { get; set; } 
            public PermanentEmployee(int salary, int year)
            {
                this.Salary = salary;
                this.Year = year;
            }

            public void CalculateSalary()
            {
                Console.WriteLine("Your salary: " + Salary);
            }
            public void CalculateBonus()
            {
                int totalBonus = Salary * Year;
                Console.WriteLine("Your bonus is: " + totalBonus);
            }
        }

        public class ContractualEmployee: IGeneralEmployee
        {
            public int Salary { get; set; }
            public int Year { get; set; }
            public ContractualEmployee(int salary)
            {
                this.Salary = salary;
            }
            public void CalculateSalary()
            {
                Console.WriteLine("Your contract salary is: " + Salary);
            }
        }

        //public class Program
        //{
        //    public static void Main(string[] args)
        //    {
        //        IGeneralEmployee permanentEmployee = new PermanentEmployee(5000, 2);
        //        //PermanentEmployee permanentEmployee = new PermanentEmployee(5000, 2);
        //        IGeneralEmployee contractualEmployee = new ContractualEmployee(8000);
        //        if (permanentEmployee is ExceptionalEmployee expEmployee)
        //            expEmployee.CalculateBonus(2, 5000);
        //        permanentEmployee.CalculateSalary();               
        //        contractualEmployee.CalculateSalary();
        //    }
        //}
    }
}
