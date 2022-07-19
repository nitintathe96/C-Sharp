using System;

namespace Assignment_No_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* If Else Selection Statement */

            int number = 10;

            if (number % 2 == 0)
            {
                Console.WriteLine(number + " is Even NUmber");
            }
            else
            {
                Console.WriteLine(number + " is Odd Number");
            }

            /* else if statements */

            int i = 10, j = 20;

            if (i == j)
            {
                Console.WriteLine("i is equal to j");
            }
            else if (i > j)
            {
                Console.WriteLine("i is greater than j");
            }
            else if (i < j)
            {
                Console.WriteLine("i is less than j");
            }

            /* Switch Statement */

            int a = 10;

            switch (a)
            {
                case 5:
                    Console.WriteLine("Value of x is 5");
                    break;
                case 10:
                    Console.WriteLine("Value of x is 10");
                    break;
                case 15:
                    Console.WriteLine("Value of x is 15");
                    break;
                default:
                    Console.WriteLine("Unknown value");
                    break;
            }

            /* For Loop */

            for (int num = 10; num > 0; num--)
            {
                Console.WriteLine("Value of i: {0}", num);
            }

            /* do while */

            int[] numberArray = { 1, 2, 3,4};

            //do-while loop to sum numbers in 4-element array.

            int sum = 0;
            int k = 0;

            do
            {
                sum += numberArray[k];
                k++;
            } while (k < 4);

            System.Console.WriteLine("Sum of integer array"+sum);

            //ForEach loop

            string[] daysArray = { "Sunday", "Monday", "TuesDay", "Wednesday", "Thursday", "Friday", "Saturday" };

            foreach (string day in daysArray)
            {
                Console.WriteLine("The day is : " + day);
            }

        }

    }
}

