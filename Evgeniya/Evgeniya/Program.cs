using System;

namespace Evgeniya
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = new int[] { 5, 6, 9, 1, 2, 3, 4 };
            int x = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                x += arr[i]; 
            }
                Console.Write(x);
        }
    }
}

