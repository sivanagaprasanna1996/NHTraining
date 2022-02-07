using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day11pro4
{
    class Mathematics
    {

        public static int Add(int a, int b)
        {
            return a + b;
        }
       
        public static int Sub(int a, int b)
        {
            return a - b;
        }
        public static int Mul(int a, int b)
        {
            return (a * b);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Mathematics.Add(8, 7));
            Console.WriteLine(Mathematics.Sub(5, 4));
            Console.WriteLine(Mathematics.Mul(3, 9));

            Console.ReadLine();
        }
    }
}

