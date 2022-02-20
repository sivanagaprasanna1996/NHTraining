using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day20pro5
{
    internal class Program
    {
        public static string GetNextNameByOut(out int id)
        {
            id = 2;
            string returnText = "Next-" + id.ToString();
            return returnText;
        }

        static void Main(string[] args)
        {
            int i = 4;
            Console.WriteLine("Previous value of integer i:" + i.ToString());
            string test = GetNextNameByOut(out i);
            Console.WriteLine("Current value of intger i:" + i.ToString());
            Console.ReadLine();

        }
    }

}
