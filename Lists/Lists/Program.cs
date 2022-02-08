using System;
using System.Collections.Generic;

namespace Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            //  This code functions perfectly in Main

            List<int> numbers = new List<int>();
            List<int> even_numbers = new List<int>();
            for (int start = 100; start <= 170; start++)
            {
                numbers.Add(start);
            }

            foreach (int number in numbers)
            {
                if (number % 2 == 0)
                {
                    even_numbers.Add(number);
                }
            }

            Console.WriteLine($"The Even Numbers list contains {even_numbers.Count} items");

            Console.WriteLine("The even numbers from 100 to 170 are: ");


            for (int i = 0; i < even_numbers.Count; i++)
            {
                Console.Write(even_numbers[i] + " ");
            }

            //Console.Writeline($"The even numbers from 100 -170 are: {foreach(i in even_numbers){Console.Writeline(i))}}");

        }

        //this is the solution to the exercise that was in the course itself
        public static List<int> Solution()
        {
            // TODO: write your solution here
            List<int> numbers = new List<int>();
            List<int> even_numbers = new List<int>();
            for (int start = 100; start <= 170; start++)
            {
                numbers.Add(start);
            }

            foreach (int number in numbers)
            {
                if (number % 2 == 0)
                {
                    even_numbers.Add(number);
                }
            }

            return even_numbers;
        }
    }
}
