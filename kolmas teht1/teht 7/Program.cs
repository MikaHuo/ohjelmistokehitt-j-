internal class Program
{
    private static void Main(string[] args)
    {
        double sel, fah;
        Console.WriteLine("Anna celsius aste jonka haluat muuttaa fahrenhitiksi");
        Console.WriteLine("Anna muutettava asteluku");
        sel = double.Parse(Console.ReadLine());
        fah = (sel * 1.8) + 32;
        Console.WriteLine(fah + " fahrenhittiä" );
    }
}