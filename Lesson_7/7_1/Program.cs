using System;

namespace SumOfDigits
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            int sum = SumOfDigits(number);
            Console.WriteLine("The sum of the digits is: " + sum);
        }

        static int SumOfDigits(int n)
        {
            if (n / 10 == 0)
            {
                return n;
            }
            else
            {
                return n % 10 + SumOfDigits(n / 10);
            }
        }
    }
}
