using MyClientApp.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClientApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AlgebraSoapClient obj = new AlgebraSoapClient();
            Console.WriteLine(obj.Factorial(5));
            Console.WriteLine(obj.Add(5, 89));
            Console.WriteLine(obj.mul(2, 13));
            Console.WriteLine(obj.sub(3, 5));
            Console.WriteLine(obj.div(6, 3));
            Console.ReadLine();

        }
    }
}
