using System;

namespace ExepcionesPersonalizadas
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
            Beer beer = new Beer()
            {
               Name = "Corona",
             //  Brand ="Cerveza"
            };


            Console.WriteLine(beer);

            }catch(InvalidBeerException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
         
        public class InvalidBeerException : Exception
        {
            public InvalidBeerException() : base("La cerveza no tiene nombre o marca , es invalido")
            {

            }
        }


        public class Beer
        {
            public string Name { get; set; }
            public string Brand { get; set; }
            public override string ToString()
            {

                if (Name == null || Brand == null)
                    throw new InvalidBeerException();

                return $"Cerveza: {Name}, Brand = {Brand}";
            }
        }


    }
}