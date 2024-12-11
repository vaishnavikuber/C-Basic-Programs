using System;
using System.Collections.Generic;
using System.Runtime.ConstrainedExecution;
using System.Text;

namespace Programs
{
    internal class AreaAndPerimeterOfCircle
    {
        const double pi = Math.PI;
        public static void areaAndPerimeter()
        {
            
            Console.WriteLine("Enter the diameter of circle");
            double diameter = double.Parse(Console.ReadLine());
            double radius = diameter / 2;
            double area = 2*pi*pi;
            double perimiter = 2 * pi * radius;
            Console.WriteLine("Area of circle is: "+area);
            Console.WriteLine("Perimeter of circle is : "+perimiter);
        }
              
    }
}
