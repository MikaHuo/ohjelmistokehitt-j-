internal class Program
{
    private static void Main(string[] args)
    {
        int numsanaksi;
        Console.WriteLine(" Tämä muuttaa numerot sanoiksi. ");
        paluu:
        try
        {
            Console.Write(" Anna numero: ");
            numsanaksi = int.Parse(Console.ReadLine());
        }
        catch (Exception ex) 
        {
            Console.WriteLine(ex.ToString());
            Console.WriteLine(" Antamisi luku ei ollut kokonaisluku! ");
            goto paluu;
        }
        if (numsanaksi < 0 || numsanaksi > 999);
        Console.WriteLine(" Annoit lukeman mitä ei voi kääntää tekstiksi kokeile uudestaan. luku tulee olla 1-999");
        goto paluu;
            
    }
}