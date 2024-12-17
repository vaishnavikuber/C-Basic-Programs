using System;
using System.Collections.Generic;
using System.Text;

namespace Programs
{
    internal class PlingPlangPlong
    {

        public static void Divisible(int num)
        {
            if (num % 3 == 0 && num % 5 == 0 && num % 7 == 0)
            {
                Console.WriteLine("Pling  Plang Plong");
            }
            else if(num% 3==0 && num % 5 == 0)
            {
                Console.WriteLine("Pling  Plang");
            }
            else if (num % 3 == 0 && num % 7 == 0)
            {
                Console.WriteLine("Pling  Plong");
            }
            else if (num % 7 == 0 && num % 5 == 0)
            {
                Console.WriteLine("Plang  Plong");
            }

            else if (num % 3 == 0)
            {
                Console.WriteLine("Pling");
            }
            else if (num % 5 == 0)
            {
                Console.WriteLine("Plang");
            }
            else if (num % 7 == 0)
            {
                Console.WriteLine("Plong");
            }

        }
    }
}
