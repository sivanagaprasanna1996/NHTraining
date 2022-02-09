using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//*******************************************
//author:j siva naga prasanna
//purpose:Read values from user and print the values
//*********************************************

namespace day13pro4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] data = new int[2, 2];
            //read value from user
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.WriteLine($"Enter array value at({i},{j})");
                    data[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            //print the values
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write(data[i, j] + " ");

                }
                Console.WriteLine("\n");
            }
            Console.ReadLine();

        }
    }
}
