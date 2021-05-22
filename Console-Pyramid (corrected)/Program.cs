using System;

namespace Console_Pyramid_corrected
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            for (a = 1; a <= 7; a++)
            {
                for (b = 6; b >= a; b--)
                {
                    Console.Write(" ");
                    Console.Write(" ");
                }
                for (c = 1; c <= (2 * a - 1); c++)
                {
                    Console.Write("*");
                    Console.Write(" ");
                }
                Console.WriteLine(new string(""));
            }
            Console.WriteLine("Press any key to continue...");
        }
    }
}