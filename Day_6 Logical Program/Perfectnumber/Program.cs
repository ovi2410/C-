using System;
public class PerfectNumber
{
    public static void Main()
    {
        int n, i, sum;
        Console.WriteLine("\n\n");
        Console.WriteLine("check given number is perfect or not:\n");
        Console.WriteLine("\n\n");
        Console.WriteLine("enter the no.");
        n = Convert.ToInt32(Console.ReadLine());
        sum = 0;
        Console.WriteLine("the positive divisor: ");
        for (i = 1; i < n; i++)
        {
            if (n % i == 0)
            {
                sum = sum + i;
                Console.WriteLine("{0} ", i);
            }
        }
        Console.WriteLine("the sum of dividor is : {0}", sum);
        if (sum == n)
            Console.WriteLine("the no. is perfect");
        else
            Console.WriteLine("the no. isnot perfect");
        Console.WriteLine("\n");
    }
}