using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//********************************************
//author:j siva naga prasanna
//purpose:declare jagged array print the values
//*********************************************

namespace day13pro8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[][] values = new int[3][];
            values[0] = new int[] { 1, 2, 3 };
            values[1] = new int[] { 4, 5, 6, 7 };
            values[2] = new int[] { 8, 9, 10, 11, 12 };

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < values[i].Length; j++)
                {
                    Console.WriteLine(values[i][j] + " ");
                }
                Console.WriteLine("\n");
            }
            Console.ReadLine();
        }
    }
}
