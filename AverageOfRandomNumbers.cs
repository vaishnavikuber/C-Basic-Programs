using System;
using System.Collections.Generic;
using System.Text;

namespace Programs
{
    internal class AverageOfRandomNumbers
    {

        public static void averageRandom()
        {
            int sum = 0;
            Random random = new Random();
            for (int i = 0; i < 5; i++)
            {
                int n = random.Next(10,50);
                Console.Write(n+" ");
                sum = sum + n;
            }
            Console.WriteLine();
            int average = sum / 5;
            Console.WriteLine("Average is : "+average);
        }


    }
}
