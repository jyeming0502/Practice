using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    public class Calculator
    {      
            public class Employee
            {
                public int Id { get; set; }
                public string Name { get; set; }
                public string Department { get; set; }
            }
        

        public class EmployeeDAL: IEmployeeDAL
        {
            public List<Employee>GetEmployees()
            {
                List<Employee> employees = new List<Employee>()
                {
                    new Employee() { Id = 1, Name = "JM", Department = "IT"},
                    new Employee() {Id = 2, Name = "ZY", Department = "R&D"}
                };
                return employees;
            }
        }

        public interface IEmployeeDAL
        {
            List<Employee> GetEmployees();
        }

        public class EmployeeBL
        {
            IEmployeeDAL employeeDAL;
            public EmployeeBL(IEmployeeDAL empDAL)
            {
                this.employeeDAL = empDAL;
            }
            public List<Employee>SelectEmployees()
            {
                List<Employee> emp = employeeDAL.GetEmployees();
                return emp;
            }
        }

        //public class Program
        //{
        //    public static void Main()
        //    {
        //        EmployeeBL emp = new EmployeeBL(new EmployeeDAL());
        //        List<Employee> empEmp = emp.SelectEmployees();
        //        foreach(Employee empE in empEmp)
        //        {
        //            Console.WriteLine("{0}, {1}", empE.Name, empE.Department);
        //        }
        //    }
        //}
    }
}
