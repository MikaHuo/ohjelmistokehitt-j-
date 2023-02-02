namespace harj_6
{
    public partial class SalasanaForm : Form
    {
        public SalasanaForm()
        {
            InitializeComponent();
        }
       
        private void TarkistaBT_Click(object sender, EventArgs e)
        {
            if(KayttajaTB.Text == "Mikko" && SalasanaTB.Text == "Mikkonen")
            {
                SalasanaPanel.Visible = false;
                SalasanaOikeinPanel.Visible = true;
            }
            else
            {
                VirheviestiLB.Text = "Käyttäjätunnus tai salasana virheellinen!";
                VirheviestiLB.Visible = true;
            }
        }

        private void SalasanaTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void SalasanaTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (KayttajaTB.Text == "Mikko" && SalasanaTB.Text == "Mikkonen")
                {
                    SalasanaPanel.Visible = false;
                    SalasanaOikeinPanel.Visible = true;
                }
                else
                {
                    VirheviestiLB.Text = "Käyttäjätunnus tai salasana virheellinen!";
                    VirheviestiLB.Visible = true;
                }
            }
        }

        private void chkBx_CheckedChanged(object sender, EventArgs e)
        {
            if(chkBx.Checked) 
            {
                SalasanaTB.PasswordChar = '\0';
                
            }
            else
            {
                SalasanaTB.PasswordChar = '*';
                
            }
        }
    }
}