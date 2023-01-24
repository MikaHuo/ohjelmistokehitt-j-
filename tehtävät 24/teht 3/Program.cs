internal class Program
{
    private static void Main(string[] args)
    {
        int luku;
        string lluku;
    takas:
        Console.WriteLine("Numerot sanoiksi ");
        Console.Write("Anna käännettävä luku: ");
        lluku= Console.ReadLine();
        try
        {
            luku = int.Parse(lluku);
        }
        catch(Exception ex)
        {
            Console.WriteLine(ex.ToString());
            Console.WriteLine(" Anna kokonaisluku: ");
            goto takas;
        }
            switch(luku)
        {
            case 1: Console.WriteLine(" yksi ");
                break;
            case 2: Console.WriteLine(" kaksi ");
                break;
            case 3: Console.WriteLine(" kolme ");
                break;
            case 4: Console.WriteLine(" neljä ");
                break;
            case 5: Console.WriteLine(" viisi ");
                break;
            case 6: Console.WriteLine(" kuusi ");
                break;
            case 7: Console.WriteLine(" seitsemän ");
                break;
            default: Console.WriteLine(" Antamasi luku pitää olla 1-7! ");
            goto takas;
        }
    }
}