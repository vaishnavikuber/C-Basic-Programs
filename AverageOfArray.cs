using System;
using System.Collections.Generic;
using System.Text;

namespace Programs
{
    internal class AverageOfArray
    {
        public static double Average(double[] array)
        {
            double total = 0;
            for(int i=0; i<array.Length; i++)
            {
                total += array[i];
            }
            return total/array.Length;
        }

    }
}
