using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace virtual_override
{
    class EnglishMessage
    {
        virtual public void PrintHi()
        {
            Console.WriteLine("Hi");
        }
        virtual public void PrintHello()
        {
            Console.WriteLine("Hello");
        }
        virtual public void PrintGM()
        {
            Console.WriteLine("Good Morning");
        }

    }
    class TeluguMessage : EnglishMessage
    {
        override public void PrintGM()
        {
            Console.WriteLine("Subodhayam");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            TeluguMessage msg = new TeluguMessage();
            msg.PrintHi();
            msg.PrintHello();
            msg.PrintGM();


            Console.ReadLine();
        }

    }
}
