using System;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {

            int a = 1;
            int b = 2;

            Show();

            Sum(2, 5);

            int m = Mul(5, 50);

            Console.WriteLine(m);
        }

        static void Sum(int arg, int arg2)
        {
            int num3 = arg + arg2;
            Console.WriteLine(num3);
        }

        static int Mul(int num1, int num2)
        {

            return num1 * num2;
        }


        static void Show()
        {
            Console.WriteLine("soy una funcion");
        }

    }
}
