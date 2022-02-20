using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day20pro2
{
    public delegate void MyCaller(int a, int b);
    internal class Program
        {
            public static void Add(int a, int b)
            {
                Console.WriteLine(a + b);
            }
            public static void Mul(int a, int b)
            {
                Console.WriteLine(a * b);
            }
            public static void Div(int a, int b)
            {
                Console.WriteLine(a / b);
            }
            static void Main(string[] args)
            {
                MyCaller mc = new MyCaller(Add);
                mc += Mul;
                mc += Div;
                // 17, 19
                mc(17, 19);
                Console.WriteLine("********************************************");
                //23,26
                mc(23, 26);
                Console.WriteLine("*********************************************");
                //34,38
                mc(34, 38);

                Console.ReadLine();
            }
        }
    }

