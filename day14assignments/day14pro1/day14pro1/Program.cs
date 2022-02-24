using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//*************************************************
//Author:J siva naga prasanna
//purpose:program to iilustrate sealed methode
//***************************************************

namespace day14project1
{
    sealed class Police
    {
        public static int Helpline = 100;
        public string Getsecret()
        {
            return "007";
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            Police p = new Police();
            Console.WriteLine(p.Getsecret());
            Console.WriteLine(Police.Helpline);
            Console.ReadLine();
        }
    }
}

