namespace Muistio2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            menuStrip1 = new MenuStrip();
            tiedostoToolStripMenuItem = new ToolStripMenuItem();
            uusiToolStripMenuItem = new ToolStripMenuItem();
            avaaToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripMenuItem();
            tallennaNimelläToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripSeparator();
            tulostuksenEsikatseluToolStripMenuItem = new ToolStripMenuItem();
            tulostaToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem3 = new ToolStripSeparator();
            suljeToolStripMenuItem = new ToolStripMenuItem();
            muotoileToolStripMenuItem = new ToolStripMenuItem();
            undoToolStripMenuItem = new ToolStripMenuItem();
            reundoToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem4 = new ToolStripSeparator();
            leikkaaToolStripMenuItem = new ToolStripMenuItem();
            kopioiToolStripMenuItem = new ToolStripMenuItem();
            liitäToolStripMenuItem = new ToolStripMenuItem();
            poistaToolStripMenuItem = new ToolStripMenuItem();
            valitseKaikkiToolStripMenuItem = new ToolStripMenuItem();
            muokkaaToolStripMenuItem = new ToolStripMenuItem();
            kirjasinToolStripMenuItem = new ToolStripMenuItem();
            tekstinKorostusToolStripMenuItem = new ToolStripMenuItem();
            tekstinRivitysToolStripMenuItem = new ToolStripMenuItem();
            apuaToolStripMenuItem = new ToolStripMenuItem();
            tietoaToolStripMenuItem = new ToolStripMenuItem();
            rikasTB = new RichTextBox();
            openFileDialog1 = new OpenFileDialog();
            saveFileDialog1 = new SaveFileDialog();
            printPreviewDialog1 = new PrintPreviewDialog();
            printDialog1 = new PrintDialog();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            fontDialog1 = new FontDialog();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(32, 32);
            menuStrip1.Items.AddRange(new ToolStripItem[] { tiedostoToolStripMenuItem, muotoileToolStripMenuItem, muokkaaToolStripMenuItem, apuaToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1075, 42);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // tiedostoToolStripMenuItem
            // 
            tiedostoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { uusiToolStripMenuItem, avaaToolStripMenuItem, toolStripMenuItem2, tallennaNimelläToolStripMenuItem, toolStripMenuItem1, tulostuksenEsikatseluToolStripMenuItem, tulostaToolStripMenuItem, toolStripMenuItem3, suljeToolStripMenuItem });
            tiedostoToolStripMenuItem.Name = "tiedostoToolStripMenuItem";
            tiedostoToolStripMenuItem.Size = new Size(126, 38);
            tiedostoToolStripMenuItem.Text = "&Tiedosto";
            // 
            // uusiToolStripMenuItem
            // 
            uusiToolStripMenuItem.Name = "uusiToolStripMenuItem";
            uusiToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.N;
            uusiToolStripMenuItem.Size = new Size(386, 44);
            uusiToolStripMenuItem.Text = "Uusi";
            uusiToolStripMenuItem.Click += uusiToolStripMenuItem_Click;
            // 
            // avaaToolStripMenuItem
            // 
            avaaToolStripMenuItem.Name = "avaaToolStripMenuItem";
            avaaToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.O;
            avaaToolStripMenuItem.Size = new Size(386, 44);
            avaaToolStripMenuItem.Text = "Avaa";
            avaaToolStripMenuItem.Click += avaaToolStripMenuItem_Click;
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.ShortcutKeys = Keys.Control | Keys.S;
            toolStripMenuItem2.Size = new Size(386, 44);
            toolStripMenuItem2.Text = "Tallenna";
            toolStripMenuItem2.Click += toolStripMenuItem2_Click;
            // 
            // tallennaNimelläToolStripMenuItem
            // 
            tallennaNimelläToolStripMenuItem.Name = "tallennaNimelläToolStripMenuItem";
            tallennaNimelläToolStripMenuItem.Size = new Size(386, 44);
            tallennaNimelläToolStripMenuItem.Text = "Tallenna nimellä...";
            tallennaNimelläToolStripMenuItem.Click += tallennaNimelläToolStripMenuItem_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(383, 6);
            // 
            // tulostuksenEsikatseluToolStripMenuItem
            // 
            tulostuksenEsikatseluToolStripMenuItem.Name = "tulostuksenEsikatseluToolStripMenuItem";
            tulostuksenEsikatseluToolStripMenuItem.Size = new Size(386, 44);
            tulostuksenEsikatseluToolStripMenuItem.Text = "Tulostuksen esikatselu";
            tulostuksenEsikatseluToolStripMenuItem.Click += tulostuksenEsikatseluToolStripMenuItem_Click;
            // 
            // tulostaToolStripMenuItem
            // 
            tulostaToolStripMenuItem.Name = "tulostaToolStripMenuItem";
            tulostaToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.P;
            tulostaToolStripMenuItem.Size = new Size(386, 44);
            tulostaToolStripMenuItem.Text = "Tulosta";
            tulostaToolStripMenuItem.Click += tulostaToolStripMenuItem_Click;
            // 
            // toolStripMenuItem3
            // 
            toolStripMenuItem3.Name = "toolStripMenuItem3";
            toolStripMenuItem3.Size = new Size(383, 6);
            // 
            // suljeToolStripMenuItem
            // 
            suljeToolStripMenuItem.Name = "suljeToolStripMenuItem";
            suljeToolStripMenuItem.ShortcutKeys = Keys.Alt | Keys.F4;
            suljeToolStripMenuItem.Size = new Size(386, 44);
            suljeToolStripMenuItem.Text = "Sulje";
            suljeToolStripMenuItem.Click += suljeToolStripMenuItem_Click;
            // 
            // muotoileToolStripMenuItem
            // 
            muotoileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { undoToolStripMenuItem, reundoToolStripMenuItem, toolStripMenuItem4, leikkaaToolStripMenuItem, kopioiToolStripMenuItem, liitäToolStripMenuItem, poistaToolStripMenuItem, valitseKaikkiToolStripMenuItem });
            muotoileToolStripMenuItem.Name = "muotoileToolStripMenuItem";
            muotoileToolStripMenuItem.Size = new Size(131, 38);
            muotoileToolStripMenuItem.Text = "&Muotoile";
            // 
            // undoToolStripMenuItem
            // 
            undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            undoToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Z;
            undoToolStripMenuItem.Size = new Size(364, 44);
            undoToolStripMenuItem.Text = "Undo";
            undoToolStripMenuItem.Click += undoToolStripMenuItem_Click;
            // 
            // reundoToolStripMenuItem
            // 
            reundoToolStripMenuItem.Name = "reundoToolStripMenuItem";
            reundoToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Y;
            reundoToolStripMenuItem.Size = new Size(364, 44);
            reundoToolStripMenuItem.Text = "Reundo";
            reundoToolStripMenuItem.Click += reundoToolStripMenuItem_Click;
            // 
            // toolStripMenuItem4
            // 
            toolStripMenuItem4.Name = "toolStripMenuItem4";
            toolStripMenuItem4.Size = new Size(361, 6);
            // 
            // leikkaaToolStripMenuItem
            // 
            leikkaaToolStripMenuItem.Name = "leikkaaToolStripMenuItem";
            leikkaaToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.X;
            leikkaaToolStripMenuItem.Size = new Size(364, 44);
            leikkaaToolStripMenuItem.Text = "Leikkaa";
            leikkaaToolStripMenuItem.Click += leikkaaToolStripMenuItem_Click;
            // 
            // kopioiToolStripMenuItem
            // 
            kopioiToolStripMenuItem.Name = "kopioiToolStripMenuItem";
            kopioiToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.C;
            kopioiToolStripMenuItem.Size = new Size(364, 44);
            kopioiToolStripMenuItem.Text = "Kopioi";
            kopioiToolStripMenuItem.Click += kopioiToolStripMenuItem_Click;
            // 
            // liitäToolStripMenuItem
            // 
            liitäToolStripMenuItem.Name = "liitäToolStripMenuItem";
            liitäToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.V;
            liitäToolStripMenuItem.Size = new Size(364, 44);
            liitäToolStripMenuItem.Text = "Liitä";
            liitäToolStripMenuItem.Click += liitäToolStripMenuItem_Click;
            // 
            // poistaToolStripMenuItem
            // 
            poistaToolStripMenuItem.Name = "poistaToolStripMenuItem";
            poistaToolStripMenuItem.Size = new Size(364, 44);
            poistaToolStripMenuItem.Text = "Poista";
            poistaToolStripMenuItem.Click += poistaToolStripMenuItem_Click;
            // 
            // valitseKaikkiToolStripMenuItem
            // 
            valitseKaikkiToolStripMenuItem.Name = "valitseKaikkiToolStripMenuItem";
            valitseKaikkiToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.A;
            valitseKaikkiToolStripMenuItem.Size = new Size(364, 44);
            valitseKaikkiToolStripMenuItem.Text = "Valitse kaikki";
            valitseKaikkiToolStripMenuItem.Click += valitseKaikkiToolStripMenuItem_Click;
            // 
            // muokkaaToolStripMenuItem
            // 
            muokkaaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { kirjasinToolStripMenuItem, tekstinKorostusToolStripMenuItem, tekstinRivitysToolStripMenuItem });
            muokkaaToolStripMenuItem.Name = "muokkaaToolStripMenuItem";
            muokkaaToolStripMenuItem.Size = new Size(132, 38);
            muokkaaToolStripMenuItem.Text = "M&uokkaa";
            // 
            // kirjasinToolStripMenuItem
            // 
            kirjasinToolStripMenuItem.Name = "kirjasinToolStripMenuItem";
            kirjasinToolStripMenuItem.Size = new Size(318, 44);
            kirjasinToolStripMenuItem.Text = "Kirjasin";
            kirjasinToolStripMenuItem.Click += kirjasinToolStripMenuItem_Click;
            // 
            // tekstinKorostusToolStripMenuItem
            // 
            tekstinKorostusToolStripMenuItem.Name = "tekstinKorostusToolStripMenuItem";
            tekstinKorostusToolStripMenuItem.Size = new Size(318, 44);
            tekstinKorostusToolStripMenuItem.Text = "Tekstin korostus";
            tekstinKorostusToolStripMenuItem.Click += tekstinKorostusToolStripMenuItem_Click;
            // 
            // tekstinRivitysToolStripMenuItem
            // 
            tekstinRivitysToolStripMenuItem.Name = "tekstinRivitysToolStripMenuItem";
            tekstinRivitysToolStripMenuItem.Size = new Size(318, 44);
            tekstinRivitysToolStripMenuItem.Text = "Tekstin rivitys";
            tekstinRivitysToolStripMenuItem.Click += tekstinRivitysToolStripMenuItem_Click;
            // 
            // apuaToolStripMenuItem
            // 
            apuaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { tietoaToolStripMenuItem });
            apuaToolStripMenuItem.Name = "apuaToolStripMenuItem";
            apuaToolStripMenuItem.Size = new Size(89, 38);
            apuaToolStripMenuItem.Text = "&Apua";
            // 
            // tietoaToolStripMenuItem
            // 
            tietoaToolStripMenuItem.Name = "tietoaToolStripMenuItem";
            tietoaToolStripMenuItem.Size = new Size(359, 44);
            tietoaToolStripMenuItem.Text = "Tietoa";
            tietoaToolStripMenuItem.Click += tietoaToolStripMenuItem_Click;
            // 
            // rikasTB
            // 
            rikasTB.Dock = DockStyle.Fill;
            rikasTB.Location = new Point(0, 42);
            rikasTB.Name = "rikasTB";
            rikasTB.Size = new Size(1075, 498);
            rikasTB.TabIndex = 1;
            rikasTB.Text = "";
            rikasTB.TextChanged += rikasTB_TextChanged;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // printPreviewDialog1
            // 
            printPreviewDialog1.AutoScrollMargin = new Size(0, 0);
            printPreviewDialog1.AutoScrollMinSize = new Size(0, 0);
            printPreviewDialog1.ClientSize = new Size(400, 300);
            printPreviewDialog1.Enabled = true;
            printPreviewDialog1.Icon = (Icon)resources.GetObject("printPreviewDialog1.Icon");
            printPreviewDialog1.Name = "printPreviewDialog1";
            printPreviewDialog1.Visible = false;
            // 
            // printDialog1
            // 
            printDialog1.UseEXDialog = true;
            // 
            // printDocument1
            // 
            printDocument1.PrintPage += printDocument1_PrintPage;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1075, 540);
            Controls.Add(rikasTB);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Muistio";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem tiedostoToolStripMenuItem;
        private ToolStripMenuItem uusiToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripMenuItem tallennaNimelläToolStripMenuItem;
        private ToolStripMenuItem tulostuksenEsikatseluToolStripMenuItem;
        private ToolStripMenuItem tulostaToolStripMenuItem;
        private ToolStripMenuItem suljeToolStripMenuItem;
        private ToolStripMenuItem muotoileToolStripMenuItem;
        private ToolStripMenuItem undoToolStripMenuItem;
        private ToolStripMenuItem reundoToolStripMenuItem;
        private ToolStripMenuItem leikkaaToolStripMenuItem;
        private ToolStripMenuItem kopioiToolStripMenuItem;
        private ToolStripMenuItem liitäToolStripMenuItem;
        private ToolStripMenuItem poistaToolStripMenuItem;
        private ToolStripMenuItem valitseKaikkiToolStripMenuItem;
        private ToolStripMenuItem muokkaaToolStripMenuItem;
        private ToolStripMenuItem kirjasinToolStripMenuItem;
        private ToolStripMenuItem tekstinKorostusToolStripMenuItem;
        private ToolStripMenuItem tekstinRivitysToolStripMenuItem;
        private ToolStripMenuItem apuaToolStripMenuItem;
        private ToolStripMenuItem tietoaToolStripMenuItem;
        private RichTextBox rikasTB;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripSeparator toolStripMenuItem3;
        private ToolStripSeparator toolStripMenuItem4;
        private ToolStripMenuItem avaaToolStripMenuItem;
        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
        private PrintPreviewDialog printPreviewDialog1;
        private PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private FontDialog fontDialog1;
    }
}