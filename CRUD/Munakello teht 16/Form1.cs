
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
            sekCB.Text = " Sekunnit ";
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
            WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer();
            wplayer.URL = "C:\\temppi csharppi\\clock-ticking-2.mp3";
            wplayer.controls.play();

            if (minCB.SelectedItem != null && sekCB.SelectedItem != null)  // tämä näyttää valitun ajan labelissa
            {
                annettuLB.Text = minCB.SelectedItem.ToString() + "min" + " : " + sekCB.SelectedItem.ToString() + "sec";
            }
                annettuLB.Visible = true;
                LB2.Visible = true;
        }

        private void pysaytaBT_Click(object sender, EventArgs e)
        {
            käynnistäBT.Enabled = true;
            pysaytaBT.Enabled = false;
            kokonaisaika = 0;
            aikaTM.Enabled = false;
            aikaLB.Text = "00:00";
            annettuLB.Visible = false;
            LB2.Visible = false;
            minCB.SelectedItem = 0; sekCB.SelectedItem = 0;
        }

        private void aikaTM_Tick(object sender, EventArgs e)
        {
            
            if (kokonaisaika > 0)
            {
                kokonaisaika--;
                int minuutit = kokonaisaika / 60;
                int sekunnit = kokonaisaika - (minuutit * 60);
                aikaLB.Text = minuutit.ToString() + ":" + sekunnit.ToString();

                
            }
            else
            {
                aikaTM.Stop();
                
                WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer();
                wplayer.URL = "C:\\temppi csharppi\\alarm-clock-01.mp3";
                wplayer.controls.play();
                MessageBox.Show("Aika Loppui BOOM!! ");
            }
        }
    }
}