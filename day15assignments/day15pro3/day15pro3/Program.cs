using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//**************************************
//Author:J siva naga prasanna
//purpose:creation of files
//**************************************

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamWriter Sr = new StreamWriter("E:\\assignments\\file programs\\Hello.txt", true);
            Sr.WriteLine("HI");
            Sr.WriteLine("i am ");
            Sr.WriteLine("Lerning");
            Sr.WriteLine("c#");
            Sr.Close();
            Console.WriteLine("File done");
            Console.ReadLine();
        }
    }
}
