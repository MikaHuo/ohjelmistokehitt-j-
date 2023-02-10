namespace Munakello_teht_16
{
    
    public partial class Form1 : Form
    {
        private int kokonaisaika;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pysaytaBT.Enabled = false;
            for(int i=0; i < 60; i++)
            {
                minCB.Items.Add(i.ToString());
                sekCB.Items.Add(i.ToString());
            }
            minCB.SelectedIndex = 0;
            minCB.Text = " Minuutit ";
            sekCB.SelectedIndex = 0;
        }

        private void käynnistäBT_Click(object sender, EventArgs e)
        {
            käynnistäBT.Enabled = false;
            pysaytaBT.Enabled = true;
            int minuutit = int.Parse(minCB.SelectedItem.ToString());
            int sekunnit = int.Parse(sekCB.SelectedItem.ToString());
            kokonaisaika = (minuutit * 60) + sekunnit;
            aikaTM.Enabled = true;
            minCB.Text = " Minuutit ";
            sekCB.Text = " Sekunnit ";

        }

        private void pysaytaBT_Click(object sender, EventArgs e)
        {
            käynnistäBT.Enabled = true;
            pysaytaBT.Enabled = false;
            kokonaisaika = 0;
            aikaTM.Enabled = false;
            aikaLB.Text = "00:00";
        }

        private void aikaTM_Tick(object sender, EventArgs e)
        {
            if(kokonaisaika > 0)
            {
                kokonaisaika--;
                int minuutit = kokonaisaika / 60;
                int sekunnit = kokonaisaika - (minuutit * 60);
                aikaLB.Text = minuutit.ToString() + ":" + sekunnit.ToString();
            }
            else
            {
                aikaTM.Stop();
                MessageBox.Show("Aika Loppui BOOM!! ");
            }
        }
    }
}