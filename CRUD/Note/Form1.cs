using System.IO;
using System.Reflection.Metadata;

namespace Note
{
   
    public partial class Form1 : Form
    {
        string tiedostoPolku = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void uusiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rikasTB.Text = "";
        }

        private void avaaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog atk = new OpenFileDialog()) 
            {
                Filter = "Rikasekstiformaatti|*.rtf", ValidateNames = true; Multiselect = false
            }
            {
                if (atk.showdialog() == DialogResult.OK)
                {
                    using (StreamReader vl = new StreamReader(atk.FileName)
                    {
                        tiedostoPolku = Atk.FileName;
                        Task<string> teksti = vl.ReadToEnAsync();
                        rikasTB.Rtf = teksti.Result;
                    }
                }
            }

        private void tallennaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tiedostoPolku))
            {
                using (SaveFileDialog ttk = new SaveFileDialog()
                {
                    Filter = "Rikastekstiformaatti|*.rtf",
                    ValidateNames = true
                })
                {
                    if (ttk.ShowDialog() == DialogResult.OK)
                    {
                        StreamWriter tiedosto = new StreamWriter(ttk.FileName);
                        tiedosto.WriteLine(this.rikasTB.Rtf);
                        tiedosto.Close();
                    }
    }

   
                }
            }
        }
        }

    }
}