internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine(" Anna kaksi lukua josta laske jako jäännös ");
        int lu1, lu2, vas;
        takas:
        try
        {
            Console.Write(" Anna ensimmäinen luku: ");
            lu1 = Int32.Parse(Console.ReadLine());
            Console.Write(" Anna toinen luku: ");
            lu2 = Int32.Parse(Console.ReadLine());
        }
        catch (Exception ex) 
        {
            Console.WriteLine(ex);
            Console.WriteLine(" Kokeile uudestaan. Anna kokonaisluku! ");
            goto takas;
        }
            vas = lu1 % lu2;
            Console.WriteLine(" Jako jäännös on: " + vas);
    }
}