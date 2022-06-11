using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Logical
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Day 6 assignment");
            //Fibinacci series
            int n1 = 0, n2 = 1, n3, number;
            Console.WriteLine("Enter no of term in series");
            number=int.Parse(Console.ReadLine());
            Console.WriteLine(n1+" "+n2 +"");

            for (int i = 2; i < number; i++)
            {
                n3 = n1 + n2;
                Console.WriteLine(n3);
                n1 = n2;
                n2 = n3;
            
            }
          //perfect number

            int number1, sum = 0, n;
            Console.WriteLine("Enter the number");
            number1 = int.Parse(Console.ReadLine());

            for (int i = 1; i < number1; i++)
            {
                if (number1 % i == 0)
                {
                    sum = sum + i;

                }
            }
                if (sum == number1)
                {
                    Console.WriteLine("no is perfect");
                }
                else {
                    Console.WriteLine("no is not perfect");
                }


          //check no is prime no or not
            int num, m = 0, flag = 0;
            Console.WriteLine("Enter the number to check prime no");
            num = int.Parse(Console.ReadLine());

            m = num / 2;
            for (int i = 2; i < m; i++) {
                if (num % i ==0){
                    Console.WriteLine("no is not prime");
                    flag = 1;
                    break;

                }

            }
            if (flag == 0)
                Console.WriteLine("No is prime");
            
            //to reverse a number
            Console.WriteLine("Enter the number to reverse");
           int num3 = int.Parse(Console.ReadLine());
            int reverse = 0;
            while (num3 > 0)
            {
                int remainder = num3 % 10;
                reverse = reverse * 10 + remainder;
                num3 = num3 / 10;
            }
                Console.WriteLine("reverse no is "+reverse);
            
//
        }


    }

  }

