using System;
namespace Ensimmäinen
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hei vaan Käyttäjä");
            Console.Write("Antaisitteko Nimenne: ");
            string name = Console.ReadLine();
            Console.Write("Hyvää Päivää, ");
            Console.Write(name);
            Console.Write();
            Console.Write("Hyvä voitte poistua Enterillä");
            Console.ReadLine();
        }
        }
}