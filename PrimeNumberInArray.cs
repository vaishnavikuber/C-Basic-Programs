using System;
using System.Collections.Generic;
using System.Text;

namespace Programs
{
    internal class PrimeNumberInArray
    {

        public static int Prime(int[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                int count = 2;
                if (nums[i] % 2 == 0)
                {
                    count++;
                }
                if(count==2)
                    return nums[i];
            }
            return -1;
        }
    }
}
