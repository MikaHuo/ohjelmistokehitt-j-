namespace teht_10
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
            this.pituus = new System.Windows.Forms.Label();
            this.painoTB = new System.Windows.Forms.TextBox();
            this.pituusTB = new System.Windows.Forms.TextBox();
            this.laskeBT = new System.Windows.Forms.Button();
            this.vastaausLB = new System.Windows.Forms.Label();
            this.vas2LB = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(73, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Anna paino: ";
            // 
            // pituus
            // 
            this.pituus.AutoSize = true;
            this.pituus.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pituus.Location = new System.Drawing.Point(73, 187);
            this.pituus.Name = "pituus";
            this.pituus.Size = new System.Drawing.Size(206, 39);
            this.pituus.TabIndex = 1;
            this.pituus.Text = "Anna pituus: ";
            // 
            // painoTB
            // 
            this.painoTB.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.painoTB.Location = new System.Drawing.Point(293, 96);
            this.painoTB.Name = "painoTB";
            this.painoTB.Size = new System.Drawing.Size(200, 46);
            this.painoTB.TabIndex = 2;
            this.painoTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pituusTB
            // 
            this.pituusTB.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pituusTB.Location = new System.Drawing.Point(293, 184);
            this.pituusTB.Name = "pituusTB";
            this.pituusTB.Size = new System.Drawing.Size(200, 46);
            this.pituusTB.TabIndex = 3;
            this.pituusTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // laskeBT
            // 
            this.laskeBT.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.laskeBT.Location = new System.Drawing.Point(73, 266);
            this.laskeBT.Name = "laskeBT";
            this.laskeBT.Size = new System.Drawing.Size(420, 46);
            this.laskeBT.TabIndex = 4;
            this.laskeBT.Text = "Laske painoindeksi";
            this.laskeBT.UseVisualStyleBackColor = true;
            this.laskeBT.Click += new System.EventHandler(this.laskeBT_Click);
            // 
            // vastaausLB
            // 
            this.vastaausLB.AutoSize = true;
            this.vastaausLB.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.vastaausLB.Location = new System.Drawing.Point(577, 99);
            this.vastaausLB.Name = "vastaausLB";
            this.vastaausLB.Size = new System.Drawing.Size(81, 39);
            this.vastaausLB.TabIndex = 5;
            this.vastaausLB.Text = "xxxx";
            this.vastaausLB.Visible = false;
            // 
            // vas2LB
            // 
            this.vas2LB.AutoSize = true;
            this.vas2LB.Font = new System.Drawing.Font("Tahoma", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.vas2LB.Location = new System.Drawing.Point(577, 187);
            this.vas2LB.Name = "vas2LB";
            this.vas2LB.Size = new System.Drawing.Size(113, 39);
            this.vas2LB.TabIndex = 6;
            this.vas2LB.Text = "xxxx2";
            this.vas2LB.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label2.Location = new System.Drawing.Point(443, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 32);
            this.label2.TabIndex = 7;
            this.label2.Text = "Cm";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label3.Location = new System.Drawing.Point(451, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 32);
            this.label3.TabIndex = 8;
            this.label3.Text = "Kg";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::teht_10.Properties.Resources._1274280503;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1056, 436);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.vas2LB);
            this.Controls.Add(this.vastaausLB);
            this.Controls.Add(this.laskeBT);
            this.Controls.Add(this.pituusTB);
            this.Controls.Add(this.painoTB);
            this.Controls.Add(this.pituus);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "BMI laskuri";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label pituus;
        private TextBox painoTB;
        private TextBox pituusTB;
        private Button laskeBT;
        private Label vastaausLB;
        private Label vas2LB;
        private Label label2;
        private Label label3;
    }
}