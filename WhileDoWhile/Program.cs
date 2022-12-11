using System;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] friends = new string[6]
            {
                "1",
                "2",
                "3",
                "4",
                "5",
                "6"
            };

            int i = 0;

            while(i < 10)
            {
                Console.WriteLine("Iteracion de i " + i);
                i++;
            }


            int j = 0;
            
            while(j < 100)
            {
                if(j > 10) break;
                Console.WriteLine("Iteracion de j " + j);
                j++;
            }

            int index = 0;

            while(index < friends.Length)
            {
                Console.WriteLine(friends[index]);
                index++;
            }  

            bool run = false;

            do
            {
                Console.WriteLine("Entre una vez");
            }while(run);    
        }
    }
}

