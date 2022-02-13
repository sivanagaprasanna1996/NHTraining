using System;
using System.Collections;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//***************************************
//Author:J siva naga prasanna
//Purpose: copy files
//***************************************

namespace day15pro11
{
    internal class Program
    {
        static void Main(string[] args)
        {

            File.Copy("E:\\assignments\\file programs\\siva\\hello", "E:\\assignments\\file programs\\siva\\quiz\\hello");
            Console.WriteLine("File created");
            Console.ReadLine();
        }
    }
}