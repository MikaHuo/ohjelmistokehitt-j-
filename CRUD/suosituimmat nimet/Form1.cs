namespace suosituimmat_nimet
{

        private void tarkastaBT_Click(object sender, EventArgs e)
        {
            vastausLB.Text = "";
            vastausLB.Visible = false;
            string[] pojat = File.ReadAllLines("C:/temppi csharppi/pojat.txt/");
            string[] tytot = File.ReadAllLines("C/temppi csharppi/tytöt.txt/");
            string nimi = nimiTB.Text;
            int laskurip = 1;
            int laskurit = 1;
            foreach (string poika in pojat)
            {
                if (nimi == poika)
                {
                    vastausLB.Text = "Nimesi on " + laskurip + " .suosituin poikien nimi vuonna 2020";
                    vastausLB.Visible = true;
                }
                laskurip++;
            }

            foreach (string tytto in tytot)
            {
                if (nimi == tytto)
                {
                    vastausLB.Text = "Nimesi on " + laskurit + ". suosituin tyttöjen nimi vuonna 2020";
                    vastausLB.Visible = true;
                }
                laskurit++;
            }
            if (vastausLB.Visible == false)
            {
                vastausLB.Text = "Nimeäsi ei löytynyt suosituimpien listalta! vaihda nimesi! ";
                vastausLB.Visible = true;
            }
        }
    }
