using System;

namespace Question_2
{
    class Program
    {
        static void Main(string[] args)
        {
             Console.Write("Enter N: ");
            int size = Int32.Parse(Console.ReadLine());

            for (int i = 1; i < size; i++)
            {
                if (i % (3 * 7) != 0) Console.WriteLine(i);
            }
        }
    }
}
