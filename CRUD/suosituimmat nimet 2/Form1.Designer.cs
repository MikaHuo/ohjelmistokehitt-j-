namespace suosituimmat_nimet_2
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
            this.vastausLB = new System.Windows.Forms.Label();
            this.tarkastaBT = new System.Windows.Forms.Button();
            this.nimiTB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(60, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(773, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tarkasta onko nimesi 50 suosituimman nimen seassa.";
            // 
            // vastausLB
            // 
            this.vastausLB.AutoSize = true;
            this.vastausLB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.vastausLB.Location = new System.Drawing.Point(15, 144);
            this.vastausLB.Name = "vastausLB";
            this.vastausLB.Size = new System.Drawing.Size(105, 45);
            this.vastausLB.TabIndex = 1;
            this.vastausLB.Text = "label2";
            this.vastausLB.Visible = false;
            // 
            // tarkastaBT
            // 
            this.tarkastaBT.BackColor = System.Drawing.SystemColors.Control;
            this.tarkastaBT.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tarkastaBT.Location = new System.Drawing.Point(525, 63);
            this.tarkastaBT.Name = "tarkastaBT";
            this.tarkastaBT.Size = new System.Drawing.Size(200, 54);
            this.tarkastaBT.TabIndex = 2;
            this.tarkastaBT.Text = "tarkasta";
            this.tarkastaBT.UseVisualStyleBackColor = false;
            this.tarkastaBT.Click += new System.EventHandler(this.tarkastaBT_Click);
            // 
            // nimiTB
            // 
            this.nimiTB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nimiTB.Location = new System.Drawing.Point(173, 63);
            this.nimiTB.Name = "nimiTB";
            this.nimiTB.Size = new System.Drawing.Size(200, 50);
            this.nimiTB.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(901, 216);
            this.Controls.Add(this.nimiTB);
            this.Controls.Add(this.tarkastaBT);
            this.Controls.Add(this.vastausLB);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label vastausLB;
        private Button tarkastaBT;
        private TextBox nimiTB;
    }
}