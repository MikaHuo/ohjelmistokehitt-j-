internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine(" Tämä ohjelma laskee perus laskutoimitukset luvuisa ");
        int las1, las2, plu, min, ker;
        double jak;
        Console.Write(" Anna ensimmäinen luku: ");
            las1 = Int32.Parse(Console.ReadLine());
        Console.Write(" Anna toinen luku: ");
            las2 = Int32.Parse(Console.ReadLine());
        plu = las1 + las2;
        min = las1 - las2;
        ker = las1 * las2;
        jak = (double) las1 / las2;
        Console.WriteLine(" Yhteen lasku on " + plu);
        Console.WriteLine(" Vähennys lasku on " + min);
        Console.WriteLine(" Kerto lasku on " + ker);
        Console.WriteLine(" Jako lasku on " + jak);
    }
}