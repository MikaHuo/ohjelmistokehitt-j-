internal class Program
{
    private static void Main(string[] args)
    {
        int luku1, luku2, tulo;
        Console.WriteLine(" Anna kaksi lukua jotka haluat laske yhteen ");
        Console.Write(" anna ensimmäinen luku ");
        luku1 =
        Int32.Parse(Console.ReadLine());
        Console.Write(" anna toinen luku ");
        luku2 =
        Int32.Parse(Console.ReadLine());
        tulo = luku1 + luku2;
        Console.WriteLine(" tulos = " + tulo );
    }
}