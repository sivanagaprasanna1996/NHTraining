using System;
using System.Collections;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//***************************************
//Author:J siva naga prasanna
//Purpose: file copy
//***************************************

namespace day15pro4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            File.Copy("E:\\assignments\\file programs\\Hello", "E:\\assignments\\file programs\\file.copy\\Hello");
            Console.WriteLine("File created");
            Console.ReadLine();
        }
    }
}
