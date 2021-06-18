﻿using System;

namespace Exercise2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            SearchWord();
        }

        private static void SearchWord()
        {
            string str;
            string wordS;
            int count = 0;
            Console.WriteLine("Enter a String");
            str = Console.ReadLine();
            Console.WriteLine("Enter a word to search");
            wordS = Console.ReadLine();
            string[] c = str.Split(' ');
            for (int i = 0; i < c.Length; i++)
            {
                if (wordS != null && wordS.Equals(c[i]))
                {
                    count++;
                }
            }

            if (count <= 1 )
            {
                Console.WriteLine($"Word found {count} time in the string");
            }
            else
            {
                Console.WriteLine($"Word found {count} times in the string");
            }
        }
    }
}