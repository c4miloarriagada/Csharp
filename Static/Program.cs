﻿using System;

namespace Static
{
    class Program
    {
        static void Main(string[] args)
        {
            People people1 = new People()
            {
                Name = "camilo",
                Age = 34
            };

            People people2 = new People()
            {
                Name = "Juan",
                Age = 30
            };

            Console.WriteLine(People.GetCount());
        }

        public static class A
        {
            public static void Some()
            {
                Console.WriteLine("algo");
            }
        }

        public class People
        {
            public static int Count = 0;
            public string Name { get; set; }
            public int Age { get; set; }    

            public People()
            {
                Count++;
            }

            public static string GetCount()
            {
                return $"Esta clase se ha utilizado  {Count} veces"; 
            }
        }
    }
}
