using System;
using System.Collections.Generic;
using System.Text;

namespace Programs
{
    internal class Person
    {

        public static void printName()
        {
            Console.WriteLine("Enter first name ,middle name, last name:");
            string name= Console.ReadLine();

            int lenght=name.Split().Length;

            Console.WriteLine("Number of parts: "+lenght);
            Console.WriteLine("name: "+name);

        }

    }
}
