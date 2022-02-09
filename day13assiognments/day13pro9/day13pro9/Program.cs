using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//*****************************************************
//author:j siva naga prasanna
//purpose:factorial of a given number using recursion
//*****************************************************

namespace fact
{
    internal class Program
    {
        static int Factorial(int n)
        {
            int fact = 1;
            for (int i = 1; i <= n; i++)
                fact = fact * i;
            return fact;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("enter any number");
            int input = Convert.ToInt32(Console.ReadLine());
            int fact = Factorial(input);
            Console.WriteLine("{0} factorial {1}", input, fact);

            Console.ReadLine();
        }
    }
}
