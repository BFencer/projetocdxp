using System;

namespace ConsoleCadastro
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Olá Mundo!");
            FazCafe("chocolate");
        }

        static void FazCafe(string strSabor)
        {
            System.Console.WriteLine("poe agua");
            System.Console.WriteLine("poe cafe");
            System.Console.WriteLine("Poe a capsula de " + strSabor);
        }
    }
}
