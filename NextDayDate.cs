using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualBasic;

namespace Programs
{
    internal class NextDayDate
    {
        public static void nextDay()
        {
            Console.WriteLine("Input the year");
            int year = int.Parse(Console.ReadLine());

            Console.WriteLine("Inout the month");
            int month = int.Parse(Console.ReadLine());

            Console.WriteLine("Input the day");
            int day = int.Parse(Console.ReadLine());

            DateTime date = new DateTime(year, month, day);
            DateTime nextDay= date.AddDays(1);
            Console.WriteLine(nextDay.Year+"-"+nextDay.Month+"-"+nextDay.Day);
            
        }
    }
}
