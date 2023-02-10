using System.IO;
namespace muistio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            string teksti = File.ReadAllText("C:\\temppi csharppi\\demo.txt");
            tekstiTB.Text = teksti;
        }

        private void tallennaBT_Click(object sender, EventArgs e)
        {
            string teksti = "";
            teksti += tekstiTB.Text;
            teksti += " " + DateTime.Now.ToString("dd.MM.yyyy HH:mm") + "\n";
            TextWriter text = new StreamWriter("C:\\temppi csharppi\\demo.txt");
            text.Write(teksti);
            text.Close();
            Application.Exit();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}