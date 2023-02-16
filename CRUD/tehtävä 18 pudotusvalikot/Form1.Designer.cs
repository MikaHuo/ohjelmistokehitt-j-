namespace tehtävä_18_pudotusvalikot
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.osLB = new System.Windows.Forms.Label();
            this.postLB = new System.Windows.Forms.Label();
            this.kauLB = new System.Windows.Forms.Label();
            this.puhLB = new System.Windows.Forms.Label();
            this.titteliLB = new System.Windows.Forms.Label();
            this.ammaLB = new System.Windows.Forms.Label();
            this.sahLB = new System.Windows.Forms.Label();
            this.tpuhLB = new System.Windows.Forms.Label();
            this.oppiCB = new System.Windows.Forms.ComboBox();
            this.henkCB = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 16.125F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(160, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(499, 52);
            this.label1.TabIndex = 0;
            this.label1.Text = "Oppilaitoksen avainhenkilöt";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(35, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(256, 36);
            this.label2.TabIndex = 1;
            this.label2.Text = "Valitse oppilaitos:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(425, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(318, 36);
            this.label3.TabIndex = 2;
            this.label3.Text = "Valitse vastuuhenkilö:";
            // 
            // osLB
            // 
            this.osLB.AutoSize = true;
            this.osLB.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.osLB.Location = new System.Drawing.Point(35, 350);
            this.osLB.Name = "osLB";
            this.osLB.Size = new System.Drawing.Size(106, 72);
            this.osLB.TabIndex = 3;
            this.osLB.Text = "Osoite\r\n.";
            // 
            // postLB
            // 
            this.postLB.AutoSize = true;
            this.postLB.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.postLB.Location = new System.Drawing.Point(29, 426);
            this.postLB.Name = "postLB";
            this.postLB.Size = new System.Drawing.Size(138, 72);
            this.postLB.TabIndex = 4;
            this.postLB.Text = "Post Nro\r\n.";
            // 
            // kauLB
            // 
            this.kauLB.AutoSize = true;
            this.kauLB.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.kauLB.Location = new System.Drawing.Point(35, 515);
            this.kauLB.Name = "kauLB";
            this.kauLB.Size = new System.Drawing.Size(147, 36);
            this.kauLB.TabIndex = 5;
            this.kauLB.Text = "Kaupunki";
            // 
            // puhLB
            // 
            this.puhLB.AutoSize = true;
            this.puhLB.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.puhLB.Location = new System.Drawing.Point(35, 594);
            this.puhLB.Name = "puhLB";
            this.puhLB.Size = new System.Drawing.Size(132, 36);
            this.puhLB.TabIndex = 6;
            this.puhLB.Text = "Puh Nro";
            // 
            // titteliLB
            // 
            this.titteliLB.AutoSize = true;
            this.titteliLB.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.titteliLB.Location = new System.Drawing.Point(425, 350);
            this.titteliLB.Name = "titteliLB";
            this.titteliLB.Size = new System.Drawing.Size(89, 36);
            this.titteliLB.TabIndex = 7;
            this.titteliLB.Text = "Titteli";
            // 
            // ammaLB
            // 
            this.ammaLB.AutoSize = true;
            this.ammaLB.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ammaLB.Location = new System.Drawing.Point(425, 426);
            this.ammaLB.Name = "ammaLB";
            this.ammaLB.Size = new System.Drawing.Size(233, 36);
            this.ammaLB.TabIndex = 8;
            this.ammaLB.Text = "Ammatti nimike";
            // 
            // sahLB
            // 
            this.sahLB.AutoSize = true;
            this.sahLB.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sahLB.Location = new System.Drawing.Point(425, 515);
            this.sahLB.Name = "sahLB";
            this.sahLB.Size = new System.Drawing.Size(170, 36);
            this.sahLB.TabIndex = 9;
            this.sahLB.Text = "Sähköposti";
            // 
            // tpuhLB
            // 
            this.tpuhLB.AutoSize = true;
            this.tpuhLB.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tpuhLB.Location = new System.Drawing.Point(425, 594);
            this.tpuhLB.Name = "tpuhLB";
            this.tpuhLB.Size = new System.Drawing.Size(181, 36);
            this.tpuhLB.TabIndex = 10;
            this.tpuhLB.Text = "Työ puh nro";
            // 
            // oppiCB
            // 
            this.oppiCB.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.oppiCB.FormattingEnabled = true;
            this.oppiCB.Location = new System.Drawing.Point(35, 230);
            this.oppiCB.Name = "oppiCB";
            this.oppiCB.Size = new System.Drawing.Size(284, 44);
            this.oppiCB.TabIndex = 11;
            this.oppiCB.SelectedIndexChanged += new System.EventHandler(this.oppiCB_SelectedIndexChanged);
            // 
            // henkCB
            // 
            this.henkCB.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.henkCB.FormattingEnabled = true;
            this.henkCB.Location = new System.Drawing.Point(425, 230);
            this.henkCB.Name = "henkCB";
            this.henkCB.Size = new System.Drawing.Size(285, 44);
            this.henkCB.TabIndex = 12;
            this.henkCB.SelectedIndexChanged += new System.EventHandler(this.henkCB_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 698);
            this.Controls.Add(this.henkCB);
            this.Controls.Add(this.oppiCB);
            this.Controls.Add(this.tpuhLB);
            this.Controls.Add(this.sahLB);
            this.Controls.Add(this.ammaLB);
            this.Controls.Add(this.titteliLB);
            this.Controls.Add(this.puhLB);
            this.Controls.Add(this.kauLB);
            this.Controls.Add(this.postLB);
            this.Controls.Add(this.osLB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label osLB;
        private Label postLB;
        private Label kauLB;
        private Label puhLB;
        private Label titteliLB;
        private Label ammaLB;
        private Label sahLB;
        private Label tpuhLB;
        private ComboBox oppiCB;
        private ComboBox henkCB;
    }
}