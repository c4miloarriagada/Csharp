using System;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {

            int op = 1;

            switch (op)
            {
                case 1:
                    Console.WriteLine("seleccionaste el 1");
                    break;

                case 2:
                    Console.WriteLine("seleccionaste 2");
                    break;
                case 3:
                case 4:
                    Console.WriteLine("Seleccionaste 3 o 4");
                break ;
                case < 0:
                case > 100:
                    Console.WriteLine("fuera de rango");
                    break;
                case > 4 and < 10:
                    Console.WriteLine("opcion entre 4 y 10");
                    break;
              default:
                    Console.WriteLine("Invalido");
                    break ;
    
            }
        }

    }
}

