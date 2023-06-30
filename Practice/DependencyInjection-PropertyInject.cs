using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    public class DependencyInjection_PropertyInject
    {
        public interface IEmployeeDAL
        {
            public List<Employee> GetAllEmployees();
        }
        public class Employee
        {
            public int ID { get; set; }
            public string Name { get; set; }
            public string Department { get; set; }
        }
        public class EmployeeDAL : IEmployeeDAL
        {
            public List<Employee> GetAllEmployees()
            {
                List<Employee> employees = new List<Employee>()
                {
                    new Employee() {ID = 1, Name = "Jyeming", Department = "IT"},
                    new Employee() {ID = 2, Name = "Zhunyee", Department = "IT"},
                };
                return employees;
            }
        }

        public class EmployeeBL
        {
            IEmployeeDAL employee;
            public IEmployeeDAL EmployeeDataObject
            {
                set { employee = value; } // the EmployeeDAL object will be the value
            }
            public List<Employee> SelectAllEmployees()
            {
                return employee.GetAllEmployees();
            }
        }

        //public class Program
        //{
        //    public static void Main(string[] args)
        //    {
        //        EmployeeBL empBL = new EmployeeBL();
        //        empBL.EmployeeDataObject = new EmployeeDAL();
        //        List<Employee> getEmp = empBL.SelectAllEmployees();
        //        foreach (Employee emp in getEmp)
        //        {
        //            Console.WriteLine("EmployeeID: {0}, Employee Name: {1}, Employee Department: {2}", emp.ID, emp.Name, emp.Department);
        //        }
        //    }
        //}
    }
}
