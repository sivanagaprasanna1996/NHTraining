using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Property_Example
{
    class Employee
    {
        private int id;
        private string name;
        private string designation;
        private int salary;


        public int Id
        {
            get { return id; }
            set { id = 102; }
        }

        public string Name
        {
            get { return name; }
            set { name = "siva"; }

        }

        public string Designation
        {
            set { designation = value; }
        }

        public int Salary
        {
            get
            {
                salary = (designation == "s") ? 30000 : 60000;
                return salary;
            }

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();

            Console.WriteLine(emp.Salary);

            Console.ReadLine();
        }
    }
}
