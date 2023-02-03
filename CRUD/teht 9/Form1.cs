namespace teht_9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void muunnaBT_Click(object sender, EventArgs e)
        {
            Double vastaus;
            double muutettava = Convert.ToDouble(syottoTB.Text);
            if(celsiusBT.Checked )
            {
                vastaus = muutettava * 1.8 + 32;
                vastausLB.Text = muutettava + " Fahrenheittia on " + Math.Round(vastaus, 2) + " Celsius astetta ";
                vastausLB.Visible = true;
            }
            else if(fahBT.Checked )
            {
                vastaus = (muutettava - 32) / 1.8;
                vastausLB.Text = muutettava + " Celsiusta on " + Math.Round(vastaus ,2) + " Fahrenheittia ";
                vastausLB.Visible = true;
            }
            else
            {
                vastausLB.Text = " Et valinnut muutettavaa astetta tai antanut oikeaa luku!";
                vastausLB.Visible = false;
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
           
        }
    }
}