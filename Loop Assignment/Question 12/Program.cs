using System;

namespace Question_12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number: ");
    int n = Int32.Parse(Console.ReadLine());    
    string binary = Convert.ToString(n, 2);
    Console.WriteLine("Result is {0}", binary);
        }
    }
}
