using System;


// Padrão .NET
namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wilson");
            if (args.GetLength(0) > 0)
            {
                Console.Write(args.GetValue(0));

            }
        }
    }
}