using System;
using System.Collections.Generic;
using System.Text;

namespace Programs
{
    public class PrintNames
    {
        public static void print()
        {
            string[] names = { "Aisha", "Vaishnav", "Bhavya", "Rutu", "Pragnya" };
            Console.WriteLine("Names:");
            foreach(string name in names)
            {
              
                Console.Write(name+"  ");
            }
        }
        
        

    }
}
