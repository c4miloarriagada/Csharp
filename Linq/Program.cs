using System;
using System.Collections.Generic;
using System.Linq;

namespace Linq
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Beer> beers = new List<Beer>()
            {
                new Beer()
                {
                    Name="Corona", Country= "Mexico"
                },
                new Beer()
                {
                    Name = "Delirium", Country = "Belgica"
                },
                new Beer()
                {
                    Name="Erdinger", Country="Alemania"
                }
            };
            foreach(var beer in beers)
                Console.WriteLine(beer);

            Console.WriteLine("---------------------------");

            //SELECT

            var beersName = from b in beers
                            select new
                            {
                                Name = b.Name,
                                Letters = b.Name.Length
                            };

            foreach(var beer in beersName)
                Console.WriteLine($"{beer.Name} {beer.Letters}");


            Console.WriteLine("-------------------------------");
            var beerNameReal = from b in beersName
                               select new
                               {
                                   Name = b.Name
                               };
            foreach(var beer in beerNameReal)
                Console.WriteLine($"{beer.Name}");
            Console.WriteLine("------------------------------");

            var beersMexico = from b in beers
                              where b.Country == "Mexico"
                              || b.Country == "Alemania"
                              select b;
            foreach(var beer in beersMexico)
                Console.WriteLine(beer);
            Console.WriteLine("------------------------------");

            var orderedBeers = from b in beers
                               orderby b.Country descending
                               select b ;

            foreach(var beer in orderedBeers)
                Console.WriteLine(beer);
        }
    }

    public class Beer
    {
        public string Name { get; set; }
        public string Country { get; set; }

        public override string ToString()
        {
            return $"Nombre: {Name} Pais : {Country}";
        }
    }

}