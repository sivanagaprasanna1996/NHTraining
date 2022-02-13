
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day15pro9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sourceFile = @"E:\assignments\file programs\\hello";
            string destination = @"E:\\assignments\\file programs\\siva\\hello";
            File.Move(sourceFile, destination);
            Console.WriteLine("file moved");

            Console.ReadLine();

        }
    }
}

