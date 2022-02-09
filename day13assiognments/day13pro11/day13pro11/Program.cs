using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//***************************************************
//author: j siva naga prasanna
//purpose: usage of stack<> using peek
//***************************************************
namespace day13pro11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> data = new Stack<int>();
            data.Push(11);
            data.Push(22);
            data.Push(33);
            Console.WriteLine(data.Count);
            Console.WriteLine(data.Peek());
            Console.WriteLine(data.Count);
            Console.ReadLine();
        }
    }
}