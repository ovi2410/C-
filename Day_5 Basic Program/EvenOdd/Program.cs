using System;
namespace evenodd
{
    class Program
    {
        static void Main(string[] args)
        {
            //variable declare
            int n;
            //take input
            Console.WriteLine("enter the number: ");
            n = Convert.ToInt32(Console.ReadLine());
            //check if n is even or odd
            if (n % 2 == 0)
                Console.WriteLine(n + " is even");
            else
                Console.WriteLine(n + " is odd");
            //wait for user to press any key
            Console.ReadKey();
        }
    }
}