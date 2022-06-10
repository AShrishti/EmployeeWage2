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
            int employee_check = r.Next(0, 3);

            if (employee_check == 1)
            {
                Console.WriteLine("Employee is present");
                 DayHour = 8;
            }

            else if(employee_check == 2)
            {
                Console.WriteLine("Employee is present and Worked part time");
                DayHour = 4;
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
