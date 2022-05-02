using System;
public class Swapno
{
    public static void Main(string[] args)
    {
        int number1, number2, temp;
        Console.WriteLine("\nenter the first number : ");
        number1 = int.Parse(Console.ReadLine());
        Console.WriteLine("\nenter the second number : ");
        number2 = int.Parse(Console.ReadLine());
        temp = number1;
            number1 = number2;
        number2 = temp;
        Console.WriteLine("\nafter swapping : ");
        Console.WriteLine("\nfirst number : " + number1);
        Console.WriteLine("\nsecond number : " + number2);
        Console.Read();
    }
}