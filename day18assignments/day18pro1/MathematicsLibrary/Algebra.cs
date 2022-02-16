using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathematicsLibrary
{
    public class Algebra
    {
        public static int Factorial(int n)
        {
            if (n == 0)
                return 1;
            else if (n < 0)
                return -9999;
            else if (n > 7)
                return -999;
            else
            {
                int fact = 1;
                for (int i = 1; i <= n; i++)
                    fact = fact * i;
                return fact;

                return 0;

            }
        }
    }
}