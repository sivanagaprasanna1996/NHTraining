using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day11pro3
{
    class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Designation { get; set; }
        public int Salary { get; set; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            emp.Id = 501;
            Console.WriteLine($"id = {emp.Id}");
            emp.Name = "siva";
            Console.WriteLine($"name = {emp.Name}");
            emp.Designation = "developer";
            Console.WriteLine($"designation = {emp.Designation}");
            emp.Salary = 45000;
            Console.WriteLine(emp.Salary);
            Console.ReadLine();

        }
    }
}

