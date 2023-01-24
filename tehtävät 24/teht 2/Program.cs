internal class Program
{
    private static void Main(string[] args)
    {
        int[] luku = new int[3];
        Console.WriteLine("Suurimman etsintä: ");
        takas:
        try
        {
            Console.WriteLine(" Anna ensimmäinen luku. ");
            luku[0] = int.Parse(Console.ReadLine());
            Console.WriteLine(" Anna toinen luku. ");
            luku[1] = int.Parse(Console.ReadLine());
            Console.WriteLine(" Anna kolmas luku. ");
            luku[2] = int.Parse(Console.ReadLine());
        }
        catch(Exception ex)  
        {
             Console.WriteLine(ex.ToString());
             Console.WriteLine(" Anna kokonailuku! Yritä uudestaan.");
            goto takas;
        }
        Array.Sort(luku);
        int viimeinen = luku.Length;
        Console.WriteLine("Suurin luku oli: " + luku[viimeinen - 1]);
    }
}