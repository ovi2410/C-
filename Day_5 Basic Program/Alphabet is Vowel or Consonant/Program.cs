using System;

namespace BasicProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            char ch;
            Console.WriteLine("Enter the alphabet:");
            ch = Convert.ToChar(Console.ReadLine());
            if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u' || ch == 'A' || ch == 'E' || ch == 'I' || ch == 'O' || ch == 'U')
            {
                Console.WriteLine("{0} is vowel", ch);
            }
            else if ((ch >= 'a' && ch <= 'z') || (ch >= 'A' && ch <= 'z'))
            {
                Console.WriteLine("{0} is consonant", ch);
            }
            Console.ReadLine();



        }
    }
}