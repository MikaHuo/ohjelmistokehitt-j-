using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tehtävä_20
{
    
    public partial class Form1 : Form
    {
        OPISKELIJA opiskelija = new OPISKELIJA();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tietotauluDG.DataSource = opiskelija.haeOpiskelijat();
        }

        private void tyhjennaBT_Click(object sender, EventArgs e)
        {

            idTB.Text = " ";
            enimiTB.Text = " ";
            snimiTB.Text = " ";
            puhTB.Text = " ";
            emailTB.Text = " ";
            onroTB.Text = " ";

        }
        private void tallennaBT_Click(object sender, EventArgs e)
        {
            string enimi = enimiTB.Text;
            string snimi = snimiTB.Text;
            string puhelin = puhTB.Text;
            string email = emailTB.Text;
            int oNro = Int32.Parse(onroTB.Text);

            if (enimi.Trim().Equals(" ") || snimi.Trim().Equals(" ") || puhelin.Trim().Equals(" ") || email.Trim().Equals(" ") || oNro.Equals(" "))
            {
                MessageBox.Show("VIRHE - Vaaditut kentät - Etu- ja sukunimi, puhelin, sähköposti ja opiskelijanumero", "Tyhjä kenttä", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Boolean lisaaAsiakas = opiskelija.lisaaOpiskelija(enimi, snimi, puhelin, email, oNro);
                if (lisaaAsiakas)
                {
                    MessageBox.Show("Uusi opiskelija lisätty onnistuneesti", "Opiskelija lisäys", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Uutta opiskelijaa ei pystytty lisäämään", "Opiskelijan lisäys", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            tietotauluDG.DataSource = opiskelija.haeOpiskelijat();
        }


        private void paivitaBT_Click(object sender, EventArgs e)
        {
            string enimi = enimiTB.Text;
            string snimi = snimiTB.Text;
            string puhelin = puhTB.Text;
            string email = emailTB.Text;
            int oNro = Int32.Parse(onroTB.Text);
            int oid = Int32.Parse(idTB.Text);

            if (oid.Equals(" ") || enimi.Trim().Equals(" ") || snimi.Trim().Equals(" ") || puhelin.Trim().Equals(" ") || email.Trim().Equals(" ") || oNro.Equals(" "))
            {
                MessageBox.Show("VIRHE - Vaaditut kentät - Etu - ja sukunimi, puhelin, sähköposti ja opiskelijanumero", "Tyhjä kenttä", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Boolean lisaaAsiakas = opiskelija.muokkaaOpiskelijaa(oid, enimi, snimi, puhelin, email, oNro);
                if (lisaaAsiakas)
                {
                    MessageBox.Show("Opiskelija päivitetty onnistuneesti", "Opiskelijan päivitys", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Opiskelijaa ei pystytty päivittämään", "Opiskelijan päivitys", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            tietotauluDG.DataSource = opiskelija.haeOpiskelijat();
        }
        private void tietotauluDG_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            idTB.Text = tietotauluDG.CurrentRow.Cells[0].Value.ToString();
            enimiTB.Text = tietotauluDG.CurrentRow.Cells[1].Value.ToString();
            snimiTB.Text = tietotauluDG.CurrentRow.Cells[2].Value.ToString();
            puhTB.Text = tietotauluDG.CurrentRow.Cells[3].Value.ToString();
            emailTB.Text = tietotauluDG.CurrentRow.Cells[4].Value.ToString();
            onroTB.Text = tietotauluDG.CurrentRow.Cells[5].Value.ToString();
        }

        private void poistaBT_Click(object sender, EventArgs e)
        {
            string ktunnus = idTB.Text;
            if (opiskelija.poistaOpiskelija(ktunnus))
            {
                tietotauluDG.DataSource = opiskelija.haeOpiskelijat();
                MessageBox.Show("Opiskelija poistettu onnistuneesti", "Opiskelijan poisto", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Opiskelija ei pystytty poistamaan", "Opiskelijan poisto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            tyhjennaBT.PerformClick();
        }

      
    }
}
