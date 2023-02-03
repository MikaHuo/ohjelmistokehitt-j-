namespace teht_10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void laskeBT_Click(object sender, EventArgs e)
        {
            double paino = 0;
            double pituus = 0;
            paino = Convert.ToDouble(painoTB.Text);
            pituus = Convert.ToDouble(pituusTB.Text);
            double bmi = Math.Round(paino / ((pituus/100) * (pituus/100)), 2);
            if (bmi < 17.9)
            {
                vastaausLB.Text = " Painoindeksisi on: " + bmi;
                vastaausLB.ForeColor = Color.Red;
                vastaausLB.Visible = true;
                vas2LB.Text = " Merkittävä alipaino! ";
                vas2LB.ForeColor = Color.Red;
                vas2LB.Visible = true;
            }
            else if(bmi < 18.5)
            {
                vastaausLB.Text = " Painoindeksisi on: " + bmi;
                vastaausLB.ForeColor = Color.BlueViolet;
                vastaausLB.Visible = true;
                vas2LB.Text = " Alipaino ";
                vas2LB.ForeColor = Color.BlueViolet;
                vas2LB.Visible = true;
            }
            else if(bmi < 25)
            {
                vastaausLB.Text = " Painoindeksisi on: " + bmi;
                vastaausLB.ForeColor = Color.Gold;
                vastaausLB.Visible = true;
                vas2LB.Text = " Normaali ";
                vas2LB.ForeColor = Color.Gold;
                vas2LB.Visible = true;
            }
            else if (bmi < 30)
            {
                vastaausLB.Text = " Painoindeksisi on: " + bmi;
                vastaausLB.ForeColor = Color.Tomato;
                vastaausLB.Visible = true;
                vas2LB.Text = " Lievä ylipaino ";
                vas2LB.ForeColor = Color.Tomato;
                vas2LB.Visible = true;
            }
            else if (bmi < 40)
            {
                vastaausLB.Text = " Painoindeksisi on: " + bmi;
                vastaausLB.ForeColor = Color.Red;
                vastaausLB.Visible = true;
                vas2LB.Text = " Ylipaino ";
                vas2LB.ForeColor = Color.Red;
                vas2LB.Visible = true;
            }
            else 
            {
                vastaausLB.Text = " Painoindeksisi on: " + bmi;
                vastaausLB.ForeColor = Color.DarkRed;
                vastaausLB.Visible = true;
                vas2LB.Text = " Sairaanloinen ylipaino ";
                vas2LB.ForeColor = Color.DarkRed;
                vas2LB.Visible = true;
            }
        }

       
    }
}