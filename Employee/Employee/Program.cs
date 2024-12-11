using System;

namespace Employee
{
    internal class Program
    {

        static void checkAttendence()
        {
            Console.WriteLine("Employee Attendence");
            Random random = new Random();
            int employeePresent = 1;
            int employeeInp = random.Next(0, 2);
            if (employeeInp==employeePresent)
            {
                Console.WriteLine("Employee is present");
            }
            else
            {
                Console.WriteLine("Employee is absent");
            }
        }

        static void Main(string[] args)
        {
            checkAttendence();

        }
    }
}
