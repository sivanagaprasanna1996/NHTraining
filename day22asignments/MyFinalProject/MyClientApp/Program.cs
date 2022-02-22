using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLogicLibrary;

namespace MyClientApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ch;
            string choice;
            do
            {
                Console.WriteLine("***********");
                Console.WriteLine("Employee Management Application");
                Console.WriteLine("***********");
                Console.WriteLine("1.Add Employee:");
                Console.WriteLine("2.Search Employee By Id:");
                Console.WriteLine("3. search Employee By name:");
                Console.WriteLine("4.Display all Employee:");
                Console.WriteLine("Enter your choice");
                ch = Convert.ToInt32(Console.ReadLine());
                switch (ch)
                {
                    case 1:
                        AddEmployee();
                        break;
                    case 2:
                        searchEmployeeById();
                        break;
                    case 3:
                        searchEmployeeByname();
                        break;
                    case 4:
                        DisplayAllEmployees();
                        break;
                    default:
                        Console.WriteLine("invalid option");
                        break;


                }

                Console.WriteLine(" do you want to continue(y/n)");
                choice = Console.ReadLine();

            }
            while (choice.Equals("y"));

        }
        public static void AddEmployee()
        {
            int Id, salary, age;
            string name;
            Console.WriteLine("Enter Id");
            Id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter salary");
            salary = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter age");
            age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter name");
            name = Console.ReadLine();
            var result = EmployeeBLL.AddEmployee(Id, name, salary, age);
            if (result)
                Console.WriteLine("Employee details saved successfully");
            else
                Console.WriteLine("some error occured");


        }
        public static void searchEmployeeById()
        {
            int id;
            Console.WriteLine("enter id:");
            id = Convert.ToInt32(Console.ReadLine());

            var result = EmployeeBLL.GetEmployeeById(id);

            if (result.Count == 0)
                Console.WriteLine("No records exists with this id:");
            else
            {
                result.ForEach(p => Console.WriteLine(p));
            }

        }
        public static void searchEmployeeByname()
        {
            string name;
            Console.WriteLine("enter name");
            name = Console.ReadLine();
            var result = EmployeeBLL.GetEmployeeByname(name);
            if (result.Count == 0)
                Console.WriteLine("no records exists with this name");
            else
            {
                result.ForEach(p => Console.WriteLine(p));
            }
        }
        public static void DisplayAllEmployees()
        {

            var result = EmployeeBLL.GetallEmployees();
            result.ToList().ForEach(p => Console.WriteLine(p));

        }
    }
}
