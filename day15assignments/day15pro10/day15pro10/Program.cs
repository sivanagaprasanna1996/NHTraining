using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day15pro10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader("E:\\assignments\\file programs\\siva\\Hello");
            String data = sr.ReadLine();
            while (data != null)
            {
                Console.WriteLine(data);
                data = sr.ReadLine();

            }
            Console.WriteLine("\n\n file reading done");
            Console.ReadLine();

        }
    }
}
