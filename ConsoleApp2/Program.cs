using System;

namespace ConsoleApp2
{
    public class Program
    {
        static void Main(string[] args)

        {
            int WagePerHour = 20;
            int DayHour = 0;
            Random r = new Random();
            int employee_check = r.Next(0, 2);

            if (employee_check == 1)
            {
                Console.WriteLine("Employee is present");
                 DayHour = 8;
            }
            else
            {
                Console.WriteLine("Employee is absent");

            }
            int DailyTotalWage = WagePerHour * DayHour;
            Console.WriteLine(DailyTotalWage);

        }

     }
}
