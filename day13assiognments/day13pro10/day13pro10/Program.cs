using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//***************************************************
//author:j siva naga prasanna
//purpose:usage of stack<>
//***************************************************
namespace day13pro10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> data = new Stack<int>();
            data.Push(25);
            data.Push(36);
            data.Push(47);
            Console.WriteLine(data.Count);
            Console.WriteLine(data.Pop());
            Console.WriteLine(data.Count);
            Console.ReadLine();
        }
    }
}

