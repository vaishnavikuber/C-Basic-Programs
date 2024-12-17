using System;
using System.Collections.Generic;
using System.Text;

namespace Programs
{
    internal class Factorial
    {

        public static int FactorialOfNumber(int num)
        {
            int fact = 1;

            do
            {
                fact = fact* num;
                num = num - 1;

            }while (num > 0);

            return fact;
        }


    }
}
