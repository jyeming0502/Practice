using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    public class ConstructorDependencyInjection
    {
        public interface IEmployeeDAL
        {
            public List<Employee> SelectAllEmployees();
        }
        public class Employee
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Department { get; set; }
        }

        public class EmployeeDAL: IEmployeeDAL
        {
            public List<Employee>SelectAllEmployees()
            {
                List<Employee> employees = new List<Employee>()
                {
                    new Employee(){Id = 1, Name = "Jyeming", Department="IT"},
                    new Employee(){Id = 1, Name = "Zhunyee", Department="IT"}
                };
                return employees;
            }
        }

        //public class EMployeeDALFactory
        //{
        //    public static EmployeeDAL GetEmployeeDALObject()
        //    {
        //        return new EmployeeDAL();
        //    }
        //}

        public class EmployeeBL
        {
            //EmployeeDAL _employeeDAL;
            //public void GetAllEmployees()
            //{
            //    _employeeDAL = EMployeeDALFactory.GetEmployeeDALObject();
            //    _employeeDAL.SelectAllEmployees();
            //}
            public IEmployeeDAL _iEmpDAL; // dependency inversion
            public EmployeeBL(IEmployeeDAL iEmpDAL) // dependency injection
            {
                _iEmpDAL = iEmpDAL;
            }
            public List<Employee> GetAllEmployees()
            {
                return _iEmpDAL.SelectAllEmployees();
            }
        }

        public class Program
        {
            public static void Main(string[] args)
            {
                EmployeeBL empBL = new EmployeeBL(new EmployeeDAL());
                List<Employee> GetEmployees = empBL.GetAllEmployees();
                foreach (Employee emp in GetEmployees)
                {
                    Console.WriteLine("Employee ID: {0}, employee name: {1}, employee department: {2}", emp.Id, emp.Name, emp.Department);
                }
            }
        }
    }
}
