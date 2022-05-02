using System;

namespace BasicProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            int number, b;
            Console.WriteLine("Enter the number to find prime factor:");
            number = Convert.ToInt32(Console.ReadLine());
            for (b = 1; b <= number; b++)
            {
                if (number % b == 0)
                {

                    Console.WriteLine("{0} is the prime factor of {1}", b, number);
                }

            }
            Console.ReadLine();



        }
    }
}