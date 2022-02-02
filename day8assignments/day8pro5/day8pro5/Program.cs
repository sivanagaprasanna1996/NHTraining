using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8project5
{
    internal class company_1
    {
        class company
        {
            public int Id;
            public string Name;
            public int Income;
        }

        static void Main(string[] args)
        {
            /************
             * Author:paluru mounika
             * Purpose:bank class more than 600000
             ************/

            List<company> company = new List<company>()
            {
                new company() { Id = 1, Name = "LNT", Income = 400000 },

                new company() { Id = 2, Name = "NBH", Income = 700000 },

                new company() { Id = 3, Name = "TCS", Income = 10000000 },

                new company() { Id = 4, Name = "INFOSIS0", Income = 300000 }
            };
            //Print the values using for loop

            for (int i = 0; i < company.Count; i++)

            {
                if (company[i].Income > 600000)
                    Console.WriteLine($"Id={company[i].Id},Name={company[i].Name},Income={company[i].Income}");
            }


            //Print the values using foreah loop

            foreach (var c in company)
            {
                if (c.Income > 600000)
                    Console.WriteLine($"Id={c.Id},Name={c.Name},income={c.Income}");
            }

            //Print values using Lambda Expression

            company.ToList().Where(b => b.Income > 60000).ToList().ForEach(c => Console.WriteLine($"Id={c.Id},Name={c.Name},income={c.Income}"));

            //print the values using LINQ

            var result = from c in company
                         where c.Income > 600000
                         select c.Name;
            result.ToList().ForEach(b => Console.WriteLine(b));

            Console.ReadLine();

        }

    }
}