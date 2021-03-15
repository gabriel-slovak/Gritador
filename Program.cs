using System;

namespace Gritador
{
    class Program
    {
        static void Main(string[] args)
        {
            string qualquerCoisa;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("----------------------");
            Console.ResetColor();
            Console.WriteLine("Realizando o Gritador!");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("----------------------");
            Console.ResetColor();
            Console.WriteLine();

            Console.Write("Digite qualquer coisa: ");
            qualquerCoisa = Console.ReadLine();
            Console.Write("\n");

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"{qualquerCoisa}!!!".ToUpper());
            Console.ResetColor();
            Console.WriteLine();


        }
    }
}
