using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace singleinheritance
{
    class Algebra
    {
        public int add(int a, int b)
        {
            return a + b;
        }
        public int sub(int a, int b)
        {
            return a - b;
        }
    }
    class TotalMaths : Algebra
    {
        public int mul(int a, int b)
        {
            return (a * b);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            TotalMaths tm = new TotalMaths();
            Console.WriteLine(tm.add(7, 6));
            Console.WriteLine(tm.sub(7, 6));
            Console.WriteLine(tm.mul(7, 6));

            Console.ReadLine();
        }
    }
}
