using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace overloadoing
{
    class Algebra
    {
        public int add(int a, int b)
        {
            return a + b;
        }
        public int add(int a, int b, int c)
        {
            return a + b + c;
        }
        public int add(int a, int b, int c, int d)
        {
            return a + b + c + d;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Algebra obj = new Algebra();
            Console.WriteLine(obj.add(7, 5));
            Console.WriteLine(obj.add(7, 4, 2));
            Console.WriteLine(obj.add(3, 2, 6, 8));

            Console.ReadLine();
            ;
        }
    }
}
