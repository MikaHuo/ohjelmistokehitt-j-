using System.Globalization;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine(" Anna lukema joka tulostetaan kyseisen määrän: ");
    paluu:
        int numero;
        try
        {
            numero = Int32.Parse(Console.ReadLine());
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            Console.WriteLine(" Anna kokonais luku! ");
            goto paluu;
        }
            for(int i = 0; i < numero; i++)
        {
            for(int j = 0; j < numero; j++)
            {
                Console.Write(numero + " ");
            }
                Console.WriteLine();
                    for(int k = 0; k < numero; k++)
            {
                Console.Write(numero);
            }
                    Console.WriteLine();
        }
    }
}