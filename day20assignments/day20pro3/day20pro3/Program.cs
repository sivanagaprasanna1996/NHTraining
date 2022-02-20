using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day20pro3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte? input = 5;
            if (input.HasValue)
                Console.WriteLine(input * input);
            else
                Console.WriteLine("No vaiue");
            Console.ReadLine();

        }
    }
}
