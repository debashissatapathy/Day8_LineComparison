using System;
using System.Collections.Generic;
using System.Text;

namespace LineComparison
{
    class UC3_Compare_Line
    {
        public void Compare_Line()
        {
            Console.WriteLine("Enter number to find line length\n");
            Console.WriteLine("Enter x1 value");
            double x1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter y1 value");
            double y1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter x2 value");
            double x2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter y2 value");
            double y2 = double.Parse(Console.ReadLine());
            double result1 = length1(x1, x2, y1, y2);
            Console.WriteLine("Length between {0}, {1} and {2}, {3} is {4:f}", x1, y1, x2, y2, result1);

            static double length1(double x1, double x2, double y1, double y2)
            {
                var count1 = Math.Pow((x2 - x1), 2);
                var count2 = Math.Pow((y2 - y1), 2);
                var result = Math.Sqrt(count1 + count2);
                return result;
            }
            Console.WriteLine("Enter a1 value");
            double a1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter b1 value");
            double b1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter a2 value");
            double a2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter b2 value");
            double b2 = double.Parse(Console.ReadLine());
            double result2 = length2(a1, b1, a2, b2);
            Console.WriteLine("Length between {0}, {1} and {2}, {3} is {4:f}", a1, b1, a2, b2, result2);

            static double length2(double a1, double b1, double a2, double b2)
            {
                var count1 = Math.Pow((a2 - a1), 2);
                var count2 = Math.Pow((b2 - b1), 2);
                var result2 = Math.Sqrt(count1 + count2);
                return result2;
            }

            if (result1.CompareTo(result2) == 0)
            {
                Console.WriteLine("Two lines are equal");
            }
            else if (result1.CompareTo(result2) < 0)
            {
                Console.WriteLine("Line1 (" + result1 + ") is less than " + "line2 (" + result2 + ").");

            }
            else
                Console.WriteLine("Line1 (" + result1 + ") is greater than " + "line2 (" + result2 + ").");
        }
    }
}
