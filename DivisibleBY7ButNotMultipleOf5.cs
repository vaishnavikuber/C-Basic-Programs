using System;
using System.Collections.Generic;
using System.Text;

namespace Programs
{
    internal class DivisibleBY7ButNotMultipleOf5
    {

        public static void method()
        {
            Console.WriteLine("The numbers that are divisible by 7 but not multiple of 5 are :");
            for (int i = 2000; i <= 3200; i++)
            {
                if ( i%7 ==0 && i%5 != 0 )
                {
                    Console.WriteLine(i);
                }
            }
        }

    }
}
