using System;

namespace ConsoleApp2
{
    public class Program
    { 
        public static void ComputeEmployeeWage(string CompanyName,int WagePerHour, int TotalWorkingDay) { 
           
           // int WagePerHour = 20;
          //  int TotalWorkingDay = 22;
            int minTime = 0;
            int DayHour = 0;

            
            for (int i = 0; i < TotalWorkingDay; i++)
            { 
                DayHour = Program.WorkingHour();
                minTime = minTime + DayHour;

                //Console.WriteLine(DayHour);
                
            }
              //  int DailyTotalWage = WagePerHour * DayHour;
            //    Console.WriteLine(DailyTotalWage);

            if (minTime >= 80 && TotalWorkingDay >= 20)
            {
                int TotalMonthlySalary = minTime * WagePerHour;
                Console.WriteLine("Total monthly salary of Employee is "+TotalMonthlySalary);
                Console.WriteLine("total hours the employee worked in the month for" + CompanyName + "is" + minTime);
            }
            else {
                Console.WriteLine("minimum workin hour not reached");
            }
 
        }
        public static int WorkingHour()
        {
            int DayHour = 0;
            Random r = new Random();
            int employee_check = r.Next(0, 3);

            switch (employee_check)
            {
                case 1:
                   Console.WriteLine("Employee is present");
                    DayHour = 8;
                    break;
                case 2:
                   Console.WriteLine("Employee is present and Worked part time");
                    DayHour = 4;
                    break;
                case 0:
                    Console.WriteLine("Employee is absent");
                    break;
            }
            return DayHour;
        }


    }
}

