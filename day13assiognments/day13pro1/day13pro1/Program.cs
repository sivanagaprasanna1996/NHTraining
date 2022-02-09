using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//********************************
//author:j siva naga prasanna
//purpose:2-d array of size[2,2] print values using nested loop
//*************************************
namespace day13pro1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] data = new int[2, 2];
            data[0, 0] = 5;
            data[0, 1] = 6;
            data[1, 0] = 45;
            data[1, 1] = 12;
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write(data[i,j] +" ");
                }
                Console.WriteLine("\n");

            }
            Console.ReadLine();

        }
    }
}