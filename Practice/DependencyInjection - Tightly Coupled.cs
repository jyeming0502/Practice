using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    public class ConstructorDependencyInjection
    {
        public class Employee
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Department { get; set; }
        }

        // low-level class
        public class EmployeeDAL 
        {
            public List<Employee> SelectAllEmployees()
            {
                List<Employee> employees = new List<Employee>()
                {
                    new Employee(){ Id = 1, Name = "Jyeming", Department="IT"},
                    new Employee(){Id = 1, Name="Zhunyee", Department="R&D"}
                };
                return employees;
            }            
        }

        // high level class because it creates object of EmployeeDAL
        // not good because EmployeeBL and EmployeeDAL are tightly coupled
        public class EmployeeBL
        {
            EmployeeDAL employeeDAL;
            public List<Employee>GetAllEmployees()
            {
                return employeeDAL.SelectAllEmployees();
            }
        }

        //public class Program
        //{
        //    public static void Main(string[] args)
        //    {
        //        EmployeeBL employeeBL = new EmployeeBL();
        //        List<Employee> employees = employeeBL.GetAllEmployees();
        //    }
        //}
    }
}
