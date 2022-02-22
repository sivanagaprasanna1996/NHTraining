using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;

namespace BusinessLogicLibrary
{
    public class EmployeeBLL
    {
        public static bool AddEmployee(int empId, string empName, int empSalary, int empAge)
        {
            var result = EmployeeDAL.AddEmployee(empId, empName, empSalary, empAge);


            return result;
        }
        public static List<string> GetEmployeeById(int id)
        {
            var result = EmployeeDAL.GetEmployeeById(id);
            return result;
        }
        public static List<string> GetEmployeeByname(string name)
        {
            var result = EmployeeDAL.GetEmployeeByname(name);
            return result;
        }
        public static string[] GetallEmployees()
        {
            var result = EmployeeDAL.GetallEmployees();
            return result;
        }
    }
}
    

