using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Programs
{
    internal class StudentScore
    {

        public static void student()
        {
            Console.WriteLine("Enter the score:");
            int score= int.Parse(Console.ReadLine());

            if (score > 0 && score <= 59)
            {
                Console.WriteLine("Grade : E");
            }
            else if(score> 59 && score <= 69)
            {
                Console.WriteLine("Grade : D");
            }
            else if(score >69 && score <= 79)
            {
                Console.WriteLine("Grade : C");
            } 
            else if (score>79 && score <= 89)
            {
                Console.WriteLine("Grade : B");
            }
            else if (score >89 && score <= 100)
            {
                Console.WriteLine("Grade : A");
            }
            else
            {
                Console.WriteLine("enter proper marks");
            }
          
        }
    }
}
