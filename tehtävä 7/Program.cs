
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Anna arvot jotka laskea -=");
        double x = int.Parse(Console.ReadLine());
        Console.WriteLine("Anna toinen arvo: ");
        double y = int.Parse(Console.ReadLine());
        double vastaus = x -= y;
        Console.WriteLine("vastaus on: " + vastaus);

    }
}