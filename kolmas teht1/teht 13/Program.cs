internal class Program
{
    private static void Main(string[] args)
    {
        string sana, usana;
        int pituus;
        Console.Clear();
        Console.WriteLine(" anna muutettava teksti ");
        sana = Console.ReadLine();
        pituus = sana.Length;
        char[] taulu = new char[pituus];
        for (int i = 0; i < pituus; i++)
            taulu[i] = sana[i];
        taulu[0] = sana[pituus-1];
        taulu[pituus - 1] = sana[0];
        usana = string.Join(" ", taulu);
        Console.WriteLine("Annoit sanan {0} ja se on muutettuja {1}", sana, usana);
    }
}