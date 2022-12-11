using System;
using System.Text.Json;

namespace JSON
{
    class Program
    {
        static void Main(string[] args)
        {
            Beer myBeer = new Beer()
            {
                Name = "Pikantus",
                Brand = "Erdinger"
            };

            //string json = "{\"Name\": \"Pikantus\", \"Brand\" : \"Erdinger\" }";

            string json = JsonSerializer.Serialize(myBeer);
            Beer beer = JsonSerializer.Deserialize<Beer>(json);

            Beer[] beers = new Beer[]
            {
                new Beer()
                {
                    Name = "Nombre",
                    Brand = "Marca"
                },
                new Beer()
                {
                    Name = "Nombre2",
                    Brand = "Marca2"
                }
            };


            string json2 = JsonSerializer.Serialize(beers);
            Beer[] beersDeserialized = JsonSerializer.Deserialize<Beer[]>(json2);

        }

        public class Beer
        {
            public string Name { get; set; }

            public string Brand { get; set; }
        }
    }
}


