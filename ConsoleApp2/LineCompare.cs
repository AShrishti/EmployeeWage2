using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class LineCompare
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to Line Comparison Computation Program on Master Branch");
            Console.WriteLine("Enter value for x1 for first line");
            int x1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter value for x2 for first line");
            int x2 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter value for y1 for first line");
            int y1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter value for y2 for first line");
            int y2 = Int32.Parse(Console.ReadLine());
            int x = (x2 - x1) * (x2 - x1);
            int y = (y2 - y1) * (y2 - y1);
            int z = x + y;
            double length1 = Math.Sqrt(z);
            Console.WriteLine("Length of the first line is" + length1);


            Console.WriteLine("Enter value for x1 for Second line");
            int x3 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter value for x2 for Second  line");
            int x4 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter value for y1 for Second  line");
            int y3 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter value for y2 for Second  line");
            int y4 = Int32.Parse(Console.ReadLine());
            int a = (x4 - x3) * (x4 - x3);
            int b = (y4 - y3) * (y4 - y3);
            int c = a + b;
            double length2 = Math.Sqrt(c);
            Console.WriteLine("Length of the first line is" + length2);

            if (length1.CompareTo(length2) == 0)
            {
                Console.WriteLine("Both the lines are equal");
            }
            else if (length1.CompareTo(length2) > 0)
            {
                Console.WriteLine("Line1 is greater than line2");
            }
            else
            {
                Console.WriteLine("Line1 is smaller than line2");
            }
        }
    }
}
