using System;
using System.Collections.Generic;
using System.Net.WebSockets;

namespace ListCommonMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>()
            {
                1,2,5,4
            };

            Show(numbers);
            //Insert
            numbers.Insert(0, 69);
            Show(numbers);
            //Contains
            if(numbers.Contains(4))
                Console.WriteLine("existe");
            else
                Console.WriteLine("No existe");
            //IndexOf
            int pos = numbers.IndexOf(4);
            Console.WriteLine(pos);

            pos = numbers.IndexOf(100);
            Console.WriteLine(pos);

            //Sort

            numbers.Sort(); //modifica los valore del objeto metodo sort es mutable
            Show(numbers);

            string name = "Camilo";

            name.ToUpper(); //no es mutable

            Console.WriteLine(name);

            //Add Range

            numbers.AddRange(new List<int>()
            {
                200,300,550
            });
            Show(numbers);
        }

        public static void Show(List<int> numbers)
        {
           Console.WriteLine("--Numeros--");
           foreach (int i in numbers)
            {
                Console.WriteLine(i);
            }
        }

    }
}

