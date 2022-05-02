using System;
public class Test
{
    public static void Main(string[] args)
    {
        int x, y, q, r;
        Console.WriteLine("enter the first number: ");
        x=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("enter the second number: ");
        y=Convert.ToInt32(Console.ReadLine());
        q = x / y;
        r = x % y;
        Console.WriteLine("Quotient is: " + q);
        Console.WriteLine("Remainder is: " + r);
    }
}