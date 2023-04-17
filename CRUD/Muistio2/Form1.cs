using System.IO;
namespace Muistio2
{
    public partial class Form1 : Form
    {
        string tiedostopolku = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void uusiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (rikasTB.Text != "")
            {
                tallennaNimell‰ToolStripMenuItem_Click(sender, e);
                rikasTB.Text = "";
            }
            else
            {
                rikasTB.Text = "";
            }
        }
        private void avaaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog atk = new OpenFileDialog()
            {
                Filter = "TextDocument|*.txt|Rich Text Format|*.rtf",
                ValidateNames = true,
                Multiselect = false,
            })
            {
                if (atk.ShowDialog() == DialogResult.OK)
                {
                    using (StreamReader v1 = new StreamReader(atk.FileName))
                    {
                        tiedostopolku = atk.FileName;
                        Task<string> teksti = v1.ReadToEndAsync();
                        rikasTB.Rtf = teksti.Result;// Oli: rikasTB.Text = teksti.Result;
                    }
                }
            }
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tiedostopolku))
            {
                using (SaveFileDialog ttk = new SaveFileDialog()
                {
                    Filter = "TextDocument|*.txt|Rich Text Format|*.rtf",
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
            else
            {
                using (StreamWriter vk = new StreamWriter(tiedostopolku))
                {
                    vk.WriteLineAsync(rikasTB.Rtf);
                }
            }
        }

        private void tallennaNimell‰ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog ttk = new SaveFileDialog()
            {
                Filter = "TextDocument|*.txt|Rich Text Format|*.rtf",
                ValidateNames = true
            })
            {
                if (ttk.ShowDialog() == DialogResult.OK)
                {
                    using (StreamWriter jonokirjoittaja = new StreamWriter(ttk.FileName))
                    {
                        jonokirjoittaja.WriteLineAsync(rikasTB.Rtf); //(Oli: rikasTB.Text);
                    }
                }
            }
        }

        private void tulostuksenEsikatseluToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void tulostaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            if (printDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void suljeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(rikasTB.Text, rikasTB.Font, Brushes.Black, 12, 10);
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rikasTB.Undo();
        }

        private void reundoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rikasTB.Redo();
        }

        private void leikkaaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rikasTB.Cut();
        }

        private void kopioiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rikasTB.Copy();
        }

        private void liit‰ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rikasTB.Paste();
        }

        private void poistaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rikasTB.SelectedText = "";
        }

        private void valitseKaikkiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rikasTB.SelectAll();
        }

        private void rikasTB_TextChanged(object sender, EventArgs e)
        {
            if (rikasTB.Text.Length > 0)
            {
                kopioiToolStripMenuItem.Enabled = true;
                leikkaaToolStripMenuItem.Enabled = true;
            }
            else
            {
                kopioiToolStripMenuItem.Enabled = false;
                leikkaaToolStripMenuItem.Enabled = false;
            }

        }

        private void tekstinRivitysToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tekstinRivitysToolStripMenuItem.Checked = true)
            {
                tekstinRivitysToolStripMenuItem.Checked = false;
                rikasTB.WordWrap = false;
            }
            else
            {
                tekstinRivitysToolStripMenuItem.Checked = true;
                rikasTB.WordWrap = false;
            }
        }

        private void kirjasinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
            rikasTB.SelectionFont = new Font(fontDialog1.Font.FontFamily, fontDialog1.Font.Size, fontDialog1.Font.Style);
        }

        private void tekstinKorostusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rikasTB.SelectionBackColor = Color.Yellow;
        }

        private void tietoaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tietoa tietoa = new tietoa();
            tietoa.ShowDialog();
        }
    }
}