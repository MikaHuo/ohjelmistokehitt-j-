namespace Noppapeli
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            piirraNoppa(noppa01PB);
            piirraNoppa(noppa02PB);
            
        }
        private void piirraNoppa(PictureBox NoppaBox)
        {
            Random satunnainen = new Random();
            int noppa = satunnainen.Next(1, 7);
            switch (noppa)
            {
                case 1:
                    NoppaBox.Image = Properties.Resources.dice01;
                    NoppaBox.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case 2:
                    NoppaBox.Image = Properties.Resources.dice02;
                    NoppaBox.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case 3:
                    NoppaBox.Image = Properties.Resources.dice03;
                    NoppaBox.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case 4:
                    NoppaBox.Image = Properties.Resources.dice04;
                        NoppaBox.SizeMode = PictureBoxSizeMode.StretchImage; 
                    break;
                case 5:
                    NoppaBox.Image = Properties.Resources.dice05;
                    NoppaBox.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case 6:
                    NoppaBox.Image = Properties.Resources.dice06;
                    NoppaBox.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}