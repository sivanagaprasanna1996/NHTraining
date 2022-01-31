using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day6liststring
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> data = new List<string>();
            data.Add("abcd");
            data.Add("efgh");
            data.Add("ijkl");
            data.Add("mnop");
            data.Add("qrst");

            for (int i = 0; i < data.Count; i++)
            {
                Console.WriteLine(data[i]);
            }
            //foreach loop
            foreach (var d in data)
                Console.WriteLine(d);

            //lamda
            data.ForEach(p => Console.WriteLine(p));
            Console.ReadLine();
        }
    }
}
