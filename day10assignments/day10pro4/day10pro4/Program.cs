using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace overriding
{
    class EnglishMessage
    {
        public void PrintHi()
        {
            Console.WriteLine("HI");
        }
        public void PrintHello()
        {
            Console.WriteLine("Hello");
        }
        public void PrintGM()
        {
            Console.WriteLine("Good Morning");
        }

    }
    class TeluguMessage : EnglishMessage
    {
        public new void PrintGM()
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
