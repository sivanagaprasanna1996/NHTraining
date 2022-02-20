using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day20pro4
{
    internal class Program
    {
       public static string GetNextName(ref int id)
        {
            string returnText = "Next-" + id.ToString();
            id += 3;
            return returnText;
        }
        static void Main(string[] args)
        {
            int i = 231;
            Console.WriteLine("Previous value of integer i:" + i.ToString());
            string test = GetNextName(ref i);
            Console.WriteLine("Current value of intger i:" + i.ToString());
            Console.ReadLine();

        }
    }
}
