using System;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] friends = new string[7]
            {
                "nombre1",
                "nombre2",
                "nombre3",
                "nombre4",
                "nombre5",
                "nombre6",
                null
            };

            friends[0] = "cualquier";

            Console.WriteLine(friends[0]);


        }

    }
}

