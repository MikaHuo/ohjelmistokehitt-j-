namespace Pankki
{ 

public class Pankkitili
{
    private readonly string m_asiakkaanNimi;
    private double m_saldo;

    private Pankkitili() { }

    public Pankkitili(string aasiakkaanNimi, double saldo)
    {
        m_asiakkaanNimi= aasiakkaanNimi;
        m_saldo= saldo;
    }
    public string AasiakkaanNimi;
}
    get
    { return m_asiakkaanNimi; }
}
    public double saldo
{
    get { return m_saldo; }
}
public void Otto(double summa)
{
    if (summa > m_saldo)
    {
        throw new ArgumentOutOfRangeException("summa");
    }
    if (summa < 0)
    {
        throw new ArgumentOutOfRangeException("summa");
    }
    m_saldo += summa;
}
    public void pano(double summa)
{
    if (summa < 0)
    {
        throw new ArgumentOutOfRangeException("summa");
    }
    m_saldo += summa;
}
        public static void Main()
{
        Pankkitili pt = new Pankkitili(" Mika Huotari", 2540,21);
        pt.Pano(300);
         pt.Otto(64, 50);
         Console.WriteLine("nykyinen saldo {0} euroa", pt.Saldo);
}