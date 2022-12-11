using System;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
           bool areUHungry = true;
            bool youHaveMoney = true;

            if (areUHungry && youHaveMoney && IsOpenRestaurant("Lonches pepe", 11))
            {
                Console.WriteLine("come");
            }
        }

        static bool IsOpenRestaurant(string name, int hour = 0)
        {
            if (name == "Lonches pepe" && hour > 8 && hour < 23)
            {
                return true;
            }else if(name == "Restaurant 24 horas")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

