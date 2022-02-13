using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//*********************************************
//Author:j siva naga prasanna
//Purpose:file
//************************************************

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(File.GetLastWriteTime("E:\\assignments\\file programs\\siva"));
            Console.ReadLine();
        }
    }
}
