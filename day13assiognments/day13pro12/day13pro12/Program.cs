using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//**************************************************
//author:j siva naga prasanna
//purpose: program to illustrate usage of  queue
//***************************************************

namespace day13pro12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<int> data = new Queue<int>();
            data.Enqueue(65);
            data.Enqueue(76);
            data.Enqueue(87);
            Console.WriteLine(data.Count);
            Console.WriteLine(data.Dequeue());
            Console.WriteLine(data.Count);
            Console.ReadLine();

        }
    }
}