using System.Diagnostics;
namespace sekunttikello_teht15
{
    public partial class Form1 : Form
    {
        private Stopwatch sekkari = new Stopwatch();
        public Form1()
        {
            InitializeComponent();
        }

        private void StartBT_Click(object sender, EventArgs e)
        {
            sekkari.Start();
        }
        private void stopBT_Click(object sender, EventArgs e)
        {
            sekkari.Stop();
        }
        private void resetBT_Click(object sender, EventArgs e)
        {
            sekkari.Reset();
        }
        private void aikaTM_Tick_1(object sender, EventArgs e)
        {
            aikaLB.Text = string.Format("{0:hh\\:mm\\:ss\\:fff}", sekkari.Elapsed);
        }

       
    }
}