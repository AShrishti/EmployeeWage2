using System;

namespace ConsoleApp2
{
    public class Program
    {
        static void Main(string[] args)

        {
            Random r = new Random();
            int employee_check = r.Next(0, 2);

            if (employee_check == 1)
            {
                Console.WriteLine("Employee is present");
            }
            else
            {
                Console.WriteLine("Employee is absent");

            }

        }

     }
}
