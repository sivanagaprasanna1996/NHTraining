using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//***************************************
//author:j siva naga prasanna
//purpose:print product id,name,brand
namespace product_id_name_price_using_4_loops
{

    class Product
    {
        public int Id;
        public string Name;
        public int Price;
        public string Brand;
    }
    internal class Program
    {


        static void Main(string[] args)
        {
            Product[] product = new Product[]
            {
                    new Product() { Id = 101, Name ="laptop", Brand="dell", Price =40000},
                    new Product() { Id = 102, Name ="desktop",Brand="hp",Price=50000},
                    new Product() { Id = 103, Name ="tv",Brand="onida",Price=30000},
                    new Product() { Id = 104, Name ="WM",Brand="cristal",Price=28000},
                    new Product() { Id = 105, Name ="fridge",Brand="samsung",Price=37000}
                      };
            Console.WriteLine("**********************");
            //price is >using FORLOOP

            for (int i = 0; i < product.Length; i++)
            {
                if (product[i].Price >= 38000)
                    Console.WriteLine($"name={product[i].Name},Brand={product[i].Brand}");

            }
            Console.WriteLine("************************");
            //price is >29000 using FOREACH LOOP
            foreach (var e in product)
            {
                if (e.Price >= 38000)
                    Console.WriteLine($"Name={e.Name},Brand{e.Brand}");
            }
            Console.WriteLine("********************");
            //price is >500 using LAMBDA EXPRESSION
            product.ToList().Where(e => e.Price >= 38000).ToList().ForEach(e => Console.WriteLine($"Name={e.Name},Brand={e.Brand}"));

            Console.WriteLine("********************");
            //price is >500 using LINQ QUERY
            var result = from e in product
                         where e.Price >= 38000
                         select e;
            result.ToList().ForEach(e => Console.WriteLine($"Name={e.Name}, Brand={e.Brand}"));
            Console.ReadLine();
        }
    }
}
