namespace teht_19_kahvila
{
    public partial class ruokalistaForm : Form
    {
        public ruokalistaForm()
        {
            InitializeComponent();
            meistaPL.Visible = true;
        }

        private void ruokalistaForm_Load(object sender, EventArgs e)
        {
            meistaLB.Text = "Keudan oppilaskunnan kahvila palvelee luokassa 120 välituntisin \n";
            meistaLB.Text += "9:00 - 14:30 joka päivä maanataista torstaisin ja perjantaisin \n";
            meistaLB.Text += "9:00 - 12: \n \n Keudan oppilaskunnan kahvilasta saa lämpimien \n";
            meistaLB.Text += "juomien lisäksi virvokkeita sekä pientä purtavaa ja makeisia \n";
            meistaLB.Text += "Tervetuloa tutustumaan! \n";
            meistaLB.Font = new Font("arial", 7);
        }

        private void meistaBT_Click(object sender, EventArgs e)
        {
            meistaPL.Visible = true;
            ruatPL.Visible = false;
            juomatPL.Visible = false;
            herkutPL.Visible = false;
            koriPL.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            meistaPL.Visible = false;
            ruatPL.Visible = true;
            juomatPL.Visible = false;
            herkutPL.Visible = false;
            koriPL.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            meistaPL.Visible = false;
            ruatPL.Visible = false;
            juomatPL.Visible = true;
            herkutPL.Visible = false;
            koriPL.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            meistaPL.Visible = false;
            ruatPL.Visible = false;
            juomatPL.Visible = false;
            herkutPL.Visible = true;
            koriPL.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            meistaPL.Visible = false;
            ruatPL.Visible = false;
            juomatPL.Visible = false;
            herkutPL.Visible = false;
            koriPL.Visible = true;
        }

        private void exitBT_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}