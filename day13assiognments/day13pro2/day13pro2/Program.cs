using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//*****************************************
//author: j siva naga prasanna
//purpose: Intializing the value in same line using nested for loop print arrays
//***********************************************

namespace day13pro2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] data = new int[3, 2] { { 36, 37 }, { 41, 47 }, { 51, 54 } };

            for (int i = 0; i < 3; i++)
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
