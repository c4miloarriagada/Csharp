// See https://akusing System;

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


         bool run = true;
         for(int i = 0; i < friends.Length && run; i++)
            {
                Console.WriteLine(friends[i]);
            }   

        }
    }
}

