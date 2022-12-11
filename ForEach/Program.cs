using System;
using System.Collections.Generic;


namespace ForEach
{
    class Program
    {
        static void Main(string[] args)
        {

            var numbers = new List<int>()
            {
                23,3,5,6,8,7,8,10
            };


            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }

            var students = new List<People>()
            {
                new People() { Name = "Camilo", Country = "Chile" },
                new People() { Name = "Hector", Country = "Mexico" },
                new People() { Name = "Pepito", Country = "Peru" },
            };
            Show(students);

            students.RemoveAt(0);

            Show(students);
        }

        static void Show(List<People> students)
        {
            Console.WriteLine("--Personas--");
            foreach (var people in students)
            {
                Console.WriteLine($"Nombre: {people.Name}, Pais: {people.Country}");
            }

        }
        

    }

    class People
    {
        public string Name { get; set; }
        public string Country { get; set; }
    }

}
