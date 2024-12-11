using System;
using System.Collections.Generic;
using System.Text;

namespace Programs
{
    internal class NumberString
    {
        public static void numstring()
        {
            Console.WriteLine("Enter the number");
            string num = Console.ReadLine();
            for (int i = 1; i <=10 ; i++)
            {
                Console.Write(num+" ");
            }
        }

    }
}
