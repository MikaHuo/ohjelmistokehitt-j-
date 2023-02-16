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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tiedostoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uusiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.avaaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.tallennaNimelläToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.tulostuksenEsikatseluToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tulostaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.suljeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.muotoileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reundoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.leikkaaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kopioiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.liitäToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.poistaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.valitseKaikkiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.muokkaaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kirjasinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tekstinKorostusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tekstinRivitysToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.apuaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tietoaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rikasTB = new System.Windows.Forms.RichTextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tiedostoToolStripMenuItem,
            this.muotoileToolStripMenuItem,
            this.muokkaaToolStripMenuItem,
            this.apuaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1075, 42);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tiedostoToolStripMenuItem
            // 
            this.tiedostoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uusiToolStripMenuItem,
            this.avaaToolStripMenuItem,
            this.toolStripMenuItem2,
            this.tallennaNimelläToolStripMenuItem,
            this.toolStripMenuItem1,
            this.tulostuksenEsikatseluToolStripMenuItem,
            this.tulostaToolStripMenuItem,
            this.toolStripMenuItem3,
            this.suljeToolStripMenuItem});
            this.tiedostoToolStripMenuItem.Name = "tiedostoToolStripMenuItem";
            this.tiedostoToolStripMenuItem.Size = new System.Drawing.Size(126, 38);
            this.tiedostoToolStripMenuItem.Text = "&Tiedosto";
            // 
            // uusiToolStripMenuItem
            // 
            this.uusiToolStripMenuItem.Name = "uusiToolStripMenuItem";
            this.uusiToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.uusiToolStripMenuItem.Size = new System.Drawing.Size(386, 44);
            this.uusiToolStripMenuItem.Text = "Uusi";
            this.uusiToolStripMenuItem.Click += new System.EventHandler(this.uusiToolStripMenuItem_Click);
            // 
            // avaaToolStripMenuItem
            // 
            this.avaaToolStripMenuItem.Name = "avaaToolStripMenuItem";
            this.avaaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.avaaToolStripMenuItem.Size = new System.Drawing.Size(386, 44);
            this.avaaToolStripMenuItem.Text = "Avaa";
            this.avaaToolStripMenuItem.Click += new System.EventHandler(this.avaaToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.toolStripMenuItem2.Size = new System.Drawing.Size(386, 44);
            this.toolStripMenuItem2.Text = "Tallenna";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // tallennaNimelläToolStripMenuItem
            // 
            this.tallennaNimelläToolStripMenuItem.Name = "tallennaNimelläToolStripMenuItem";
            this.tallennaNimelläToolStripMenuItem.Size = new System.Drawing.Size(386, 44);
            this.tallennaNimelläToolStripMenuItem.Text = "Tallenna nimellä...";
            this.tallennaNimelläToolStripMenuItem.Click += new System.EventHandler(this.tallennaNimelläToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(383, 6);
            // 
            // tulostuksenEsikatseluToolStripMenuItem
            // 
            this.tulostuksenEsikatseluToolStripMenuItem.Name = "tulostuksenEsikatseluToolStripMenuItem";
            this.tulostuksenEsikatseluToolStripMenuItem.Size = new System.Drawing.Size(386, 44);
            this.tulostuksenEsikatseluToolStripMenuItem.Text = "Tulostuksen esikatselu";
            this.tulostuksenEsikatseluToolStripMenuItem.Click += new System.EventHandler(this.tulostuksenEsikatseluToolStripMenuItem_Click);
            // 
            // tulostaToolStripMenuItem
            // 
            this.tulostaToolStripMenuItem.Name = "tulostaToolStripMenuItem";
            this.tulostaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.tulostaToolStripMenuItem.Size = new System.Drawing.Size(386, 44);
            this.tulostaToolStripMenuItem.Text = "Tulosta";
            this.tulostaToolStripMenuItem.Click += new System.EventHandler(this.tulostaToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(383, 6);
            // 
            // suljeToolStripMenuItem
            // 
            this.suljeToolStripMenuItem.Name = "suljeToolStripMenuItem";
            this.suljeToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.suljeToolStripMenuItem.Size = new System.Drawing.Size(386, 44);
            this.suljeToolStripMenuItem.Text = "Sulje";
            this.suljeToolStripMenuItem.Click += new System.EventHandler(this.suljeToolStripMenuItem_Click);
            // 
            // muotoileToolStripMenuItem
            // 
            this.muotoileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoToolStripMenuItem,
            this.reundoToolStripMenuItem,
            this.toolStripMenuItem4,
            this.leikkaaToolStripMenuItem,
            this.kopioiToolStripMenuItem,
            this.liitäToolStripMenuItem,
            this.poistaToolStripMenuItem,
            this.valitseKaikkiToolStripMenuItem});
            this.muotoileToolStripMenuItem.Name = "muotoileToolStripMenuItem";
            this.muotoileToolStripMenuItem.Size = new System.Drawing.Size(131, 38);
            this.muotoileToolStripMenuItem.Text = "&Muotoile";
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(364, 44);
            this.undoToolStripMenuItem.Text = "Undo";
            this.undoToolStripMenuItem.Click += new System.EventHandler(this.undoToolStripMenuItem_Click);
            // 
            // reundoToolStripMenuItem
            // 
            this.reundoToolStripMenuItem.Name = "reundoToolStripMenuItem";
            this.reundoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.reundoToolStripMenuItem.Size = new System.Drawing.Size(364, 44);
            this.reundoToolStripMenuItem.Text = "Reundo";
            this.reundoToolStripMenuItem.Click += new System.EventHandler(this.reundoToolStripMenuItem_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(361, 6);
            // 
            // leikkaaToolStripMenuItem
            // 
            this.leikkaaToolStripMenuItem.Name = "leikkaaToolStripMenuItem";
            this.leikkaaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.leikkaaToolStripMenuItem.Size = new System.Drawing.Size(364, 44);
            this.leikkaaToolStripMenuItem.Text = "Leikkaa";
            this.leikkaaToolStripMenuItem.Click += new System.EventHandler(this.leikkaaToolStripMenuItem_Click);
            // 
            // kopioiToolStripMenuItem
            // 
            this.kopioiToolStripMenuItem.Name = "kopioiToolStripMenuItem";
            this.kopioiToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.kopioiToolStripMenuItem.Size = new System.Drawing.Size(364, 44);
            this.kopioiToolStripMenuItem.Text = "Kopioi";
            this.kopioiToolStripMenuItem.Click += new System.EventHandler(this.kopioiToolStripMenuItem_Click);
            // 
            // liitäToolStripMenuItem
            // 
            this.liitäToolStripMenuItem.Name = "liitäToolStripMenuItem";
            this.liitäToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.liitäToolStripMenuItem.Size = new System.Drawing.Size(364, 44);
            this.liitäToolStripMenuItem.Text = "Liitä";
            this.liitäToolStripMenuItem.Click += new System.EventHandler(this.liitäToolStripMenuItem_Click);
            // 
            // poistaToolStripMenuItem
            // 
            this.poistaToolStripMenuItem.Name = "poistaToolStripMenuItem";
            this.poistaToolStripMenuItem.Size = new System.Drawing.Size(364, 44);
            this.poistaToolStripMenuItem.Text = "Poista";
            this.poistaToolStripMenuItem.Click += new System.EventHandler(this.poistaToolStripMenuItem_Click);
            // 
            // valitseKaikkiToolStripMenuItem
            // 
            this.valitseKaikkiToolStripMenuItem.Name = "valitseKaikkiToolStripMenuItem";
            this.valitseKaikkiToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.valitseKaikkiToolStripMenuItem.Size = new System.Drawing.Size(364, 44);
            this.valitseKaikkiToolStripMenuItem.Text = "Valitse kaikki";
            this.valitseKaikkiToolStripMenuItem.Click += new System.EventHandler(this.valitseKaikkiToolStripMenuItem_Click);
            // 
            // muokkaaToolStripMenuItem
            // 
            this.muokkaaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kirjasinToolStripMenuItem,
            this.tekstinKorostusToolStripMenuItem,
            this.tekstinRivitysToolStripMenuItem});
            this.muokkaaToolStripMenuItem.Name = "muokkaaToolStripMenuItem";
            this.muokkaaToolStripMenuItem.Size = new System.Drawing.Size(132, 38);
            this.muokkaaToolStripMenuItem.Text = "M&uokkaa";
            // 
            // kirjasinToolStripMenuItem
            // 
            this.kirjasinToolStripMenuItem.Name = "kirjasinToolStripMenuItem";
            this.kirjasinToolStripMenuItem.Size = new System.Drawing.Size(318, 44);
            this.kirjasinToolStripMenuItem.Text = "Kirjasin";
            this.kirjasinToolStripMenuItem.Click += new System.EventHandler(this.kirjasinToolStripMenuItem_Click);
            // 
            // tekstinKorostusToolStripMenuItem
            // 
            this.tekstinKorostusToolStripMenuItem.Name = "tekstinKorostusToolStripMenuItem";
            this.tekstinKorostusToolStripMenuItem.Size = new System.Drawing.Size(318, 44);
            this.tekstinKorostusToolStripMenuItem.Text = "Tekstin korostus";
            this.tekstinKorostusToolStripMenuItem.Click += new System.EventHandler(this.tekstinKorostusToolStripMenuItem_Click);
            // 
            // tekstinRivitysToolStripMenuItem
            // 
            this.tekstinRivitysToolStripMenuItem.Name = "tekstinRivitysToolStripMenuItem";
            this.tekstinRivitysToolStripMenuItem.Size = new System.Drawing.Size(318, 44);
            this.tekstinRivitysToolStripMenuItem.Text = "Tekstin rivitys";
            this.tekstinRivitysToolStripMenuItem.Click += new System.EventHandler(this.tekstinRivitysToolStripMenuItem_Click);
            // 
            // apuaToolStripMenuItem
            // 
            this.apuaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tietoaToolStripMenuItem});
            this.apuaToolStripMenuItem.Name = "apuaToolStripMenuItem";
            this.apuaToolStripMenuItem.Size = new System.Drawing.Size(89, 38);
            this.apuaToolStripMenuItem.Text = "&Apua";
            // 
            // tietoaToolStripMenuItem
            // 
            this.tietoaToolStripMenuItem.Name = "tietoaToolStripMenuItem";
            this.tietoaToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.tietoaToolStripMenuItem.Text = "Tietoa";
            this.tietoaToolStripMenuItem.Click += new System.EventHandler(this.tietoaToolStripMenuItem_Click);
            // 
            // rikasTB
            // 
            this.rikasTB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rikasTB.Location = new System.Drawing.Point(0, 42);
            this.rikasTB.Name = "rikasTB";
            this.rikasTB.Size = new System.Drawing.Size(1075, 498);
            this.rikasTB.TabIndex = 1;
            this.rikasTB.Text = "";
            this.rikasTB.TextChanged += new System.EventHandler(this.rikasTB_TextChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1075, 540);
            this.Controls.Add(this.rikasTB);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Muistio";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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