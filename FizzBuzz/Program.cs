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
            //int oddTotal = 0;
            //int[] grades = new int[] { 98, 75, 84, 26, 47, 21 };

            //for (int i = 0; i <= grades.Length; i++)
            //{
            //    if (grades[i] % 2 == 0)
            //    {
            //        oddTotal += grades[i];
            //    }
            //}
            //Console.WriteLine(oddTotal);
            //Console.Read();


            // Given an array of integers, write a method to sum the elements in the array, knowing that some of the elements may be very large integers.

            // Given a string, reverse it.
            // See StringHelper class for ReverseString method.

            string t = "Products";
            Console.WriteLine(StringHelper.ReverseString(t));

            Console.WriteLine(StringHelper.ReverseString("Switzerland"));

            // Given a string, remove any repeated letters.

            string input2 = "Duncan Howard-McGuire";
            var filteredString = new StringBuilder();
            foreach (char c in input2)
            {
                if (filteredString.ToString().IndexOf(c) == -1)
                {
                    filteredString.Append(c);
                }
            }
            Console.WriteLine(filteredString);
            Console.ReadKey();

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
