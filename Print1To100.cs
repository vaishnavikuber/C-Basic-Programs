using System;
using System.Collections.Generic;
using System.Text;

namespace Programs
{
    internal class Print1To100
    {

        
        public static void PrintNum(int n)
        {
            if(n> 0) { 

                PrintNum(n - 1);
                Console.Write(n + "  ");
            }
        }
    }
}
