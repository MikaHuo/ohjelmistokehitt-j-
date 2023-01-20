internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hei vaan Käyttäjä");
        Console.Write("Antaisitteko Nimenne: ");
        string name = Console.ReadLine();
        Console.Write("Hyvää Päivää, ");
        Console.Write(name);
    }
}