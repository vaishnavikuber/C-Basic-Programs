using System;
using System.Collections.Generic;
using System.Text;

namespace Programs
{
    internal class ShiftZeroToEnd
    {

        public static void Shift(int[] array)
        {
            int l=array.Length-1;
            for(int f = 0; f < l; f++)
            {
                
                if (array[f] == 0)
                {

                    if (array[l] != 0)
                    {

                        int temp = array[f];
                        array[f] = array[l];
                        array[l] = temp;
                        l--;
                    }
                    if (array[l] == 0)
                        l--;
                }
                if (array[l] == 0)
                    l--;
            }

            for (int i=0; i< array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }

        }

    }
}
