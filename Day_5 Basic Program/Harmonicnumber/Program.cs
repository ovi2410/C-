using System;
public class Harmonic
{
    public static void Main(string[] args)
    {
        int i, n;
        double s = 0.0;
        Console.WriteLine("\n\n");
        Console.WriteLine("\ncalculate the hormonic series nd sum: ");
        Console.WriteLine("input the number of terms");
        n=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("\n\n");
        for(i=1;i<=n;i++)
        {
            Console.WriteLine("1/{0} + ", i);
            s += 1 / (float)i;
            Console.WriteLine("\nsum of series upto{0} terms : {1}\n",n,s);
        }
    }

}