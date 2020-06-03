using System;
using System.Collections.Generic;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type the number of Fibonacci elements ");
            
            while (true)
            {
                if (Int32.TryParse(Console.ReadLine(), out int n))
                {
                    for (int i = 0; i < n; i++)
                        Console.WriteLine(Fibo(i));
                    break;
                }
            }
        }

        public static int Fibo(int n)
        {
            if (n == 0) return 0;
            if (n < 3) return 1;
            else return Fibo(n - 2) + Fibo(n - 1);
        }
    }
}
