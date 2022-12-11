using System;
using System.Net.WebSockets;

namespace Tuplas
{
    class Program
    {
        static void Main(string[] args)
        {
            (int id, string name) product = (1, "cerveza stout");

            Console.WriteLine($"{product.name} {product.id}"); //tuplas se pueden editar y cambiar valores.


            product.name = "Cerveza porter";

            Console.WriteLine($"{product.name} {product.id}");


            var person = (1, "Camilo");
            Console.WriteLine($"{person.Item1} {person.Item2}");

            var people = new[] //deben ser los mismos tipos de datos.
            {
                (1, "Camilo"),
                (2, "Pedro"),
                (3, "Juan")
            };

            foreach(var p in people)
            {
                Console.WriteLine($"{p.Item1} {p.Item2}");
            }

            (int id, string name)[] people2 = new[]
            {
                (1, "Camilo"),
                (2, "Pedro"),
                (3, "Juan")
            };

            foreach (var p in people2)
            {
                Console.WriteLine($"{p.id} {p.name}");
            }

            var cityInfo = getLocationScl();
            Console.WriteLine($"{cityInfo.lat} {cityInfo.lng} {cityInfo.name}");

            var (_, lng, _) = getLocationScl();

            Console.WriteLine($"{lng}");
        }

        public static (float lat, float lng, string name) getLocationScl()
        {
            float lat = 19.2884f;

            float lng = -99.15615f;
            
            string name = "SCL";
            

            return (lat, lng, name);
        }

    }
}
