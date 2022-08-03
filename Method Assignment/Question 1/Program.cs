using System;

namespace Question_1
{
    class Program
    {
        public static string PrintName()
	{
		string name = Console.ReadLine();
		string printname = "Hello, " + name + "!";
		Console.WriteLine(printname);
		return printname;
    }
        static void Main(string[] args)
        {
           PrintName(); 
        }
    }
}
