using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//******************************
//author:j siva naga prasanna
//pupose:intiliaze the array print trace of array
//*******************************

namespace day13pro3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] data = new int[3, 3] { { 11, 12, 13 }, { 21, 22, 23 }, { 31, 32, 33 } };
            int sum = 0;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (i == j)
                        sum = sum + data[i, j];
                }
                Console.WriteLine("\n");
            }
            Console.WriteLine(sum);
            Console.ReadLine();
        }

    }
}
