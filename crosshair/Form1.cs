using System.Windows.Forms;
using System.Xml.Linq;

namespace crosshair
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            TopMost = true;
        }

            private void crossCB_SelectedIndexChanged(object sender, EventArgs e)
            {

            if (crossCB.SelectedIndex == 0)
            {
                crossPB.Image = Image.FromFile(@"C:\Users\mhuot\Pictures\Saved Pictures\cross1.png");
            }
            else if (crossCB.SelectedIndex == 1)
            {
                crossPB.Image = Image.FromFile(@"C:\Users\mhuot\Pictures\Saved Pictures\cross2.png");
            }
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            changeGB.Visible = false;

        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.H)
            {
                changeGB.Visible = true;
            }
            else
            {
                changeGB.Visible = false;

            }

        }
        private void redRB_CheckedChanged(object sender, EventArgs e)
        {
            if (redRB.Checked)
            {
                Bitmap bmp = new Bitmap(@"C:\Users\mhuot\Pictures\Saved Pictures\cross2.png");
                for (int x = 0; x < bmp.Width; x++)
                {
                    for (int y = 0; y < bmp.Height; y++)
                    {
                        Color pixelColor = bmp.GetPixel(x, y);

                        if (pixelColor == Color.Red)
                        {
                            bmp.SetPixel(x, y, Color.Black);
                        }
                    }
                }
                crossPB.Image = bmp;
            }
        }
    }
 }
