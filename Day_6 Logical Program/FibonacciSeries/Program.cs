using System;
namespace FibonacciSeries
{
    public class program
    {
        public static void Main()
        {
            int firstnumber = 0, secondnumber = 1, nextNumber, numberofElements;
            Console.WriteLine("enter the no. of elements to print: ");
            numberofElements = int.Parse(Console.ReadLine());
            if (numberofElements < 2)
            {
                Console.WriteLine("plz enter a no. greater than two");

            }
            else
            {
                //first print 1st nd 2nd no.
                Console.WriteLine(firstnumber + " " + secondnumber + " ");
                //start the loop from 2 i.e. 0 nd 1 are already printed
                for (int i = 2; i < numberofElements; i++)
                {
                    nextNumber = firstnumber + secondnumber;
                    Console.WriteLine(nextNumber + " ");
                    firstnumber = secondnumber;
                    secondnumber = nextNumber;
                }
            }
        }
        
    }
}