using System;
using System.Collections.Generic;
using System.Text;

namespace Programs
{
    public class SquareAndDifferenceOfTwoNumbers
    {

        public static void squareAndDifference(double a,double b)
        {
            double sumOfSquareOfNumbers = sumSquare(a,b);
            Console.WriteLine("Sum of square of number is: "+sumOfSquareOfNumbers);
            double diffOfSquareOfNumbers = diffSquare(a, b);
            Console.WriteLine("Difference of square of number is: " + diffOfSquareOfNumbers);
        }
        static double sumSquare(double a,double b)
        {
            double num = a + b;
            return num*num;
        }
        static double diffSquare(double a, double b)
        {
            double num = a - b;
            return num*num;
        }
    }
}
