using System;

class reverse
{
    static void Main(string[] args)
    {
        int a = 345, rev = 0, b;
        while (a != 0)
        {
            b = a % 10;
            rev = (rev * 10) + b;
            a = a / 10;
        }
        Console.WriteLine("the reverse no. is: " + rev);
    }
}