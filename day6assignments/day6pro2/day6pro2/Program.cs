using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day6pro2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> data = new List<int>();
            int sum = 0;
            data.Add(8);
            data.Add(9);
            data.Add(10);
            data.Add(11);
            data.Add(22);

            foreach (var d in data)
            {
                sum = sum + d;
            }
            Console.WriteLine(sum);
            Console.ReadKey();
        }
    }
}
