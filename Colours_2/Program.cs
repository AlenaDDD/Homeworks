using System;

class MainClass
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Напишите свой любимый цвет на английском с маленькой буквы");
        var color = Console.ReadLine();

        if (color == "red")
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.Black;

            Console.WriteLine("Your colour is red!");
        }
        else if (color == "black")
        {
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Black;

            Console.WriteLine("Your colour is green!");
        }
        else
        {
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.ForegroundColor = ConsoleColor.Black;

            Console.WriteLine("Your colour is cyan!");
        }
    }
}