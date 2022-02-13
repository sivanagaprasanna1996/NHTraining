using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day15pro7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string curFile = @"E:\\assignments\\file programs\\hello";

            Console.WriteLine(File.Exists("E:\\assignments\\file programs\\hello") ? "File exits" : "File deos not exits");


            Console.ReadLine();
        }
    }
}
