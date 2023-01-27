namespace grud_koulussa
{
    public partial class Harjoitus1 : Form
    {
        public Harjoitus1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (OtsikkoLB.Text == "Heippa maailma!")
            {
                OtsikkoLB.Text = "Otsikko";
            }        
            else
            {
                OtsikkoLB.Text = "Heippa maailma!";
            }
        }
    }
}