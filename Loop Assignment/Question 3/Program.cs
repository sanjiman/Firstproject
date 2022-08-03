using System;

namespace Question_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int lowest = 0, highest = 0, input;

            Console.Write("Enter a digit length: ");
            int lenght = Int32.Parse(Console.ReadLine());            

            for (int i = 0; i < lenght; i++)
            {
                Console.Write("Enter a digit: ");
                input = Int32.Parse(Console.ReadLine());
                if (i == 0) lowest = highest = input;
                else
                {
                    if (lowest > input) lowest = input;
                    if (highest < input) highest = input;
                }                
            }
            Console.WriteLine("Lowest - {0}, Highest - {1}", lowest, highest);
        }
    }
}
