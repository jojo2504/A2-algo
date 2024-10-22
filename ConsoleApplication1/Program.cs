using System.Collections.Generic;
using System.Linq;
using System;
using System.Globalization;

namespace ConsoleApplication1
{
    class Program
    {
        public static List<int> numbers = new List<int>();
        static int fibo(int n)
        {
            if (n == 0 || n == 1)
            {
                return n;
            }

            if (numbers.Contains(n))
            {
                return n;
            }
            numbers.Add(n);
            return fibo(n - 1) + fibo(n - 2);
        }        
        
        static void Main(string[] args)
        {
            Console.WriteLine(fibo(100));
        }
    }
}