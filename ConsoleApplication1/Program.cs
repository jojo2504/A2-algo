using System.Collections.Generic;
using System.Linq;
using System;
using System.Globalization;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(recursiveTD.Factorielle(4));
            Console.WriteLine(recursiveTD.Factorielle_Terminale(4));
            Console.WriteLine(recursiveTD.Fibbonachi(4));
            Console.WriteLine(recursiveTD.Fibbonachi(0));
            Console.WriteLine(recursiveTD.Fibbonachi(1));
            Console.WriteLine(recursiveTD.Inversion("maison"));
            Console.WriteLine(recursiveTD.Palindrome("maison"));
            Console.WriteLine(recursiveTD.Palindrome("maam"));
            
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 8, 7, 6, 5, 4, 3, 2, 1 }; //should return 9
            Console.WriteLine(recursiveTD.MaxIndex(array));
            Console.WriteLine(recursiveTD.MaxIndex(new int[]{}));
            
            Console.WriteLine(recursiveTD.RechDichoRecursif(new int[]{1,2,3}, 2));
            Console.WriteLine(recursiveTD.RechDichoRecursif(new int[]{1}, 9));
            
            Console.WriteLine(string.Join(", ", recursiveTD.TriFusion(array).Select(x => x.ToString())));
        }
    }
}