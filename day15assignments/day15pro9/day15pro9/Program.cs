
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//*************************************
//Author:J Siva Naga Prasanna
//Purpose:creation of file accesstime
//*****************************************

namespace day15pro9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(File.GetLastAccessTime("E:\\assignments\\file programs"));
            Console.ReadLine();
        }
    }
}
