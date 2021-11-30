using System;

namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        {
            int A = Convert.ToInt32(Console.ReadLine());
            int B = Convert.ToInt32(Console.ReadLine());
            double X = double.Parse(Console.ReadLine());
            double Y = double.Parse(Console.ReadLine());
            bool C = (A < B) || (X > Y);
            Console.WriteLine(C);
        }
    }
}
