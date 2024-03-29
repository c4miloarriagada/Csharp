﻿using System;
using System.Collections.Generic;


namespace Lists
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> numbers = new List<int>();

            numbers.Add(5);
            numbers.Add(2);


            Console.WriteLine(numbers.Count);

            List<int> numbers2 = new List<int>()
            {
                1,6,7,8,9,10,11
            };
            Console.WriteLine(numbers2.Count);


            numbers2.Add(55);

            Console.WriteLine(numbers2.Count);


            numbers2.Clear();
            Console.WriteLine(numbers2.Count);


            List<string> countries = new List<string>()
            {
                "Mexico", "Chile", "Argentina"
            };

            Console.WriteLine(countries.Count);
        }

    }
}

