namespace harj_7
{
    public partial class Form1 : Form
    {
     
       

        private void kivuCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            double laina, neste, vakuutus, pesu, huollot, renkaat, muut, kilometrit, polttiaine, kustannus;
            laina = Convert.ToDouble(lainaTB.Text);
            neste = Convert.ToDouble(nesteTB.Text);
            pesu = Convert.ToDouble(pesuTB.Text);
            vakuutus = Convert.ToDouble(pesuTB.Text);
            huollot = Convert.ToDouble(huoltoTB.Text);
            renkaat = Convert.ToDouble(renkaatTB.Text);
            muut = Convert.ToDouble(muuTB.Text);
            polttiaine = Convert.ToDouble(polttoaineTB.Text);
            kilometrit = Convert.ToDouble(kivuCB.Text);
            kustannus = (laina + neste + vakuutus + pesu + huollot + renkaat + muut + polttiaine) / (kilometrit / 12);

            kkkLB.Text = "kustannus " + kustannus;
            kkkLB.Visible= true;
        }

     
    }
}