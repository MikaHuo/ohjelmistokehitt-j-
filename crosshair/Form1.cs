using System.Globalization;
using System.Runtime.Intrinsics.X86;
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

        Bitmap b2;
        
        private void Form1_Load(object sender, EventArgs e)
        {
            TopMost = true;
        }

        private void crossCB_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (crossCB.SelectedIndex == 0)
            {
                crossPB.Image = Image.FromFile(@"C:\Users\mhuot\Pictures\Saved Pictures\cross13.png");
            }
            else if (crossCB.SelectedIndex == 1)
            {
                crossPB.Image = Image.FromFile(@"C:\Users\mhuot\Pictures\Saved Pictures\cross2.png");
            }
            else if (crossCB.SelectedIndex == 2)
            {
                crossPB.Image = Image.FromFile(@"C:\Users\mhuot\Pictures\Saved Pictures\cross1.png");
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

      

        private void crossPB_Click(object sender, EventArgs e)
        {
            OpenFileDialog vkm = new OpenFileDialog();
            vkm.Filter = "Image |*.png;*.jpg";
            vkm.FileOk += vkm_FileOk;
            vkm.ShowDialog();
        }

        private void vkm_FileOk(object sender, EventArgs e)
        {
            OpenFileDialog o = sender as OpenFileDialog;
            b2 = new Bitmap(o.FileName);
            Bitmap p1 = new Bitmap(o.FileName);
            Bitmap p2 = new Bitmap(p1,new Size(p1.Width / 3, p1.Height / 3));
            crossPB.Load(o.FileName);
        }

        private void redRB_CheckedChanged(object sender, EventArgs e)
        {
            Bitmap b3 = new Bitmap(b2.Width, b2.Height);
            for (int i = 0; i < b2.Height; i++)
            {
                for (int j = 0; j < b2.Height; j++)
                {
                    if (b2.GetPixel(i, j).R == redRB.BackColor.R && b2.GetPixel(i, j).G == redRB.BackColor.G && b2.GetPixel(i, j).B == redRB.BackColor.B) b3.SetPixel(i, j, Color.Black); 
                    else b3.SetPixel(i,j, b2.GetPixel(i, j));
                }
            }
        }
        /*

        private void redRB_CheckedChanged(object sender, EventArgs e)
        {

            Bitmap originalBitmap = new Bitmap("crossPB");
            for (int x = 0; x < originalBitmap.Width; x++)
            {
                for (int y = 0; y < originalBitmap.Height; y++)
                {
                    Color pixelColor = originalBitmap.GetPixel(x, y);
                    if (pixelColor.R == 255 && pixelColor.G == 0 && pixelColor.B == 0)
                    {
                        originalBitmap.SetPixel(x, y, Color.Black);
                    }
                }
            }
            crossPB.Image = originalBitmap;
            // 237,31,36,255

            /* if (redRB.Checked)
            {
                Bitmap bmp = new Bitmap("crossPB");
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
        }*/
    }
}

