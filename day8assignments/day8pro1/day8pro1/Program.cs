
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
//****************
//AUTHOR:j siva naga prasanna
//purpose:print employee id ,salary,name
//****************

    namespace employee_id_name_salary_using_4_loops
    {
        class Employee
        {
            public int Id;
            public string Name;
            public int salary;
        }


        internal class Program
        {


            static void Main(string[] args)
            {
                List<Employee> employees = new List<Employee>()
            {
                new Employee(){ Id = 101, Name = "siva", salary = 15000 },
                new Employee(){ Id = 102, Name = "hanuman reddy", salary = 10000 },
                new Employee() { Id = 103, Name = "naveen", salary = 20000 },
                new Employee() { Id = 104, Name = "raaju", salary = 30000 },
                new Employee() { Id = 105, Name = "venky", salary = 40000 },
            };
                // create employees using FOR LOOP
                for (int i = 0; i < employees.Count; i++)
                {
                    Console.WriteLine($"id={employees[i].Id},name={employees[i].Name}, salary={employees[i].salary}");

                }
                Console.WriteLine("*******");
                // create employeees using FOREACH LOOP
                foreach (var e in employees)
                {
                    Console.WriteLine($"id ={e.Id}, name={e.Name}, salary={e.salary}");
                }
                Console.WriteLine("********");
                // create employees using LAMBDA EXPRESSION
                employees.ToList().ForEach(e => Console.WriteLine($"id{e.Id}, name={e.Name}, salary={e.salary}"));
                Console.WriteLine("*******");
                // create employees using LINQ QUERY
                var result = from e in employees
                             select e;
                result.ToList().ForEach(e => Console.WriteLine($"id{e.Id},name={e.Name},salary={e.salary}"));

                Console.ReadLine();

            }
        }
    }

   