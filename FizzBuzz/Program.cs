using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class Program
    {
        static void Main()
        {
            // Total only odd numbers in array

            int[] score = new int[] { 1, 5, 6, 2, 8, 15, 13, 17, 4, 12 };
            int sum = 0;
            for (int i = 0; i <= 9; i++)
            {
                if (score[i] % 2 == 1)
                {
                    sum = sum + score[i];
                }
            }
            Console.WriteLine("Sum:" + sum);


            // Given an array of integers, write a method to sum the elements in the array, knowing that some of the elements may be very large integers.

            int[] arr = new int[] { 1, 2, 3 };
            int sum2 = 0;
            foreach (var i in arr)
            {
                sum2 += i;
            }
            Console.WriteLine(sum2);

            // OR, using LINQ...

            int sum3 = arr.Sum();

            // Given a string, reverse it.

            string p = "Products";
            Console.WriteLine(StringHelper.ReverseString(p));
            Console.WriteLine(StringHelper.ReverseString("Switzerland"));

            string t = "terrible";
            Console.WriteLine(StringHelper.ReverseStringDirect(t));
            Console.WriteLine(StringHelper.ReverseStringDirect("Germany"));


            // Given a string, remove any repeated letters.

            string name = "Duncan Howard-McGuire";
            var filteredString = new StringBuilder();
            foreach (char c in name)
            {
                if (filteredString.ToString().IndexOf(c) == -1)
                {
                    filteredString.Append(c);
                }
            }
            Console.WriteLine(filteredString);

            // FizzBuzz

            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
            Console.Read();
        }
    }
}
