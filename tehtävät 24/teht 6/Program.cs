internal class Program
{
    private static void Main(string[] args)
    {
        int numero;
        Console.WriteLine("Bonuksia:");
        palautus:
        try
        {
            Console.WriteLine(" Anna luku bonuksille ");
            numero = int.Parse(Console.ReadLine());
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex);
            Console.WriteLine(" Antamasi luku ei ole kokonaisluku! ");
            goto palautus;
        }
            switch(numero) 
        {
            case 1:
            case 2:
            case 3:
                Console.WriteLine(numero + " Luvusta bonus on: " + 10 * numero); 
            break;
            case 4:
            case 5:
            case 6:
                Console.WriteLine(numero + " Luvusta bonus on: " + 100 * numero);
                break;
            case 7:
            case 8:
            case 9:
                Console.WriteLine(numero + " Luvusta bonus on: " + 1000 * numero);
                break;
                 default: Console.WriteLine(" Antamasi lukemat ovat 1-9 ulokopuolella!");
                goto palautus;
                break;
                
        }
    }
}