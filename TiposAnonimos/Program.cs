// See https://akausing System;

namespace TiposAnonimos
{
    class Program
    {
        static void Main(string[] args)
        {
            var camilo = new
            {
                Name = "Camilo",
                Country = "Chile"
            };

            Console.WriteLine($"{camilo.Name} {camilo.Country}");


            // camilo.Name = "no me deja";

            var beers = new[]
            {
                new {Name = "Red", brand="Delirium"},
                new {Name ="London Porter", brand= "Fullers"}
            };

            foreach(var b in beers)
            {
                Console.WriteLine($"cerveza: {b.Name} {b.brand}");
            }

        }

    }
}

