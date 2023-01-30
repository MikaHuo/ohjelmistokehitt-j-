internal class Program
{
    private static void Main(string[] args)
    {
        int luku1, luku2;
        
        Console.WriteLine("Onko lukema positiivinen vai negatiivinen:");
    paluu:
        try
        {
            Console.Write(" Anna ensimmäinen luku: ");
           luku1 = int.Parse(Console.ReadLine());
            Console.Write(" Anna toinen luku: ");
            luku2= int.Parse(Console.ReadLine());
        }
        catch (Exception ex) 
        {
            Console.WriteLine(ex.ToString());
            Console.Write("Et antnut kokonais lukua! ");
            goto paluu;
        }
        if (luku1 > 0)
        {
            Console.WriteLine(luku1 + " luku1 on positiivinen");
        }
        else
        {
            Console.WriteLine(luku1 + " Luku1 on negatiivinen");
        }
        if (luku2 > 0)
        {
            Console.WriteLine(luku2 + " Luku2 on positiivinen");
        }
        else 
        {
            Console.WriteLine(luku2 + " Luku2 on negatiivinen");

        }
    }
}