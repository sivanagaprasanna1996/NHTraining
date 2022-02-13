using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//********************************************
//Author:J siva naga prasanna
//Purpose:

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            File.Create("E:\\assignments\\file programs\\Hello.txt");
            Console.WriteLine("file created");
            Console.ReadLine();

        }
    }
}
