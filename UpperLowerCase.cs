using System;
using System.Collections.Generic;
using System.Text;

namespace Programs
{
    internal class UpperLowerCase
    {

        public static void lowerUpper()
        {
            Console.WriteLine("Enter the place name:");
            string placeName=Console.ReadLine();
            string lower = placeName.ToLower();
            string upper = placeName.ToUpper();
            Console.WriteLine("Upper case: "+upper);
            Console.WriteLine("Lower case: "+lower);

        }

    }
}
