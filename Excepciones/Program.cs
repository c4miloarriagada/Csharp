using System;
using System.IO;

namespace Excepciones
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string content = File.ReadAllText(@"C:\Users\devca\OneDrive\Escritorio\Estudio\textoc#.txt");
                Console.WriteLine(content);

                string content2 = File.ReadAllText(@"C:\Users\devca\OneDrive\Escritorio\Estudio\textoc#2.txt");
                Console.WriteLine(content);

                throw new Exception("FALLO");
            }catch(FileNotFoundException ex)
            {
                Console.WriteLine("el archivo no existe");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("aqui me voy a ejecutar si o si");
            }
        }
    }
}