using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//**************************************************
//author:j siva naga prasanna
//purpose: program to illustrate usage of  queue using peek
//***************************************************

namespace day13project12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<int> data = new Queue<int>();
            data.Enqueue(105);
            data.Enqueue(116);
            data.Enqueue(127);
            Console.WriteLine(data.Count);
            Console.WriteLine(data.Peek());
            Console.WriteLine(data.Count);
            Console.ReadLine();

        }
    }
}
