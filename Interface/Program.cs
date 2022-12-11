using System;
using System.Security.Cryptography.X509Certificates;

namespace Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            Shark[] sharks = new Shark[]
            {
                new Shark("Tiburonsin", 50),
                new Shark("Jaws", 65)
            };


            Ifish[] fish = new Ifish[]
            {
                new Siren(100),
                new Shark("Tiburinsin", 5812)
            };



            ShowFish(sharks);
            ShowAnimals(sharks);
            ShowFish(fish);

        }

        public static void ShowFish(Ifish[] fish)
        {
            Console.WriteLine("-Mostramos peces-");

            int i = 0;
            while(i < fish.Length)
            {
                Console.WriteLine(fish[i].Swim());
                i++;
            }
        }
        public static void ShowAnimals(IAnimal[] animals)
        {
            Console.WriteLine("-Mostramos Animales-");

            int i = 0;
            while (i < animals.Length)
            {
                Console.WriteLine(animals[i].Name);
                i++;
            }
        }


    }
    public class Siren : Ifish
    {
        public int Speed { get; set; }


        public Siren(int speed)
        {
            this.Speed = speed;
        }

        public string Swim()
        {
            return $"La sirena Nada a {Speed} km/h";
        }
    }

    public class Shark: IAnimal, Ifish
    {   


        public string Name { get; set; }
        public int Speed { get; set; }
            
        public Shark(string Name, int Speed)
        {
            this.Name = Name;
            this.Speed = Speed; 
        }

        public string Swim()
        {
            return $"{Name} y nada a {Speed} km/h";
        }
    }

    public interface IAnimal
    {
        public string Name { get; set; } 

    }
    public interface Ifish
    {
        public int Speed { get; set; }
        public string Swim();
    }

}