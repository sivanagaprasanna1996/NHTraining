using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//*******************************************
//Author:J siva naga prasanna
//Purpose:prime number or not( using break)
//*******************************************

namespace day14pro4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 17, i;
            for (i = 2; i < n; i++)
            {
                if (n % i == 0)
                    break;
            }
            if (i == n)
                Console.WriteLine("prime number");
            else
                Console.WriteLine("not a prime number");
            Console.ReadLine();
        }
    }
}
