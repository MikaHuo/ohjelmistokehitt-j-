namespace Harjoitus3
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
            this.luku1TB = new System.Windows.Forms.TextBox();
            this.luku2TB = new System.Windows.Forms.TextBox();
            this.merkkiCB = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.vastausLB = new System.Windows.Forms.Label();
            this.vastausBT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // luku1TB
            // 
            this.luku1TB.Font = new System.Drawing.Font("Segoe UI", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.luku1TB.Location = new System.Drawing.Point(56, 101);
            this.luku1TB.Multiline = true;
            this.luku1TB.Name = "luku1TB";
            this.luku1TB.Size = new System.Drawing.Size(296, 76);
            this.luku1TB.TabIndex = 0;
            // 
            // luku2TB
            // 
            this.luku2TB.Font = new System.Drawing.Font("Segoe UI", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.luku2TB.Location = new System.Drawing.Point(470, 101);
            this.luku2TB.Multiline = true;
            this.luku2TB.Name = "luku2TB";
            this.luku2TB.Size = new System.Drawing.Size(296, 76);
            this.luku2TB.TabIndex = 1;
            // 
            // merkkiCB
            // 
            this.merkkiCB.Font = new System.Drawing.Font("Segoe UI", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.merkkiCB.FormattingEnabled = true;
            this.merkkiCB.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "/"});
            this.merkkiCB.Location = new System.Drawing.Point(358, 101);
            this.merkkiCB.Name = "merkkiCB";
            this.merkkiCB.Size = new System.Drawing.Size(106, 67);
            this.merkkiCB.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(789, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 50);
            this.label1.TabIndex = 3;
            this.label1.Text = "=";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // vastausLB
            // 
            this.vastausLB.AutoSize = true;
            this.vastausLB.Font = new System.Drawing.Font("Segoe UI", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.vastausLB.Location = new System.Drawing.Point(863, 111);
            this.vastausLB.Name = "vastausLB";
            this.vastausLB.Size = new System.Drawing.Size(168, 59);
            this.vastausLB.TabIndex = 4;
            this.vastausLB.Text = "Vastaus";
            // 
            // vastausBT
            // 
            this.vastausBT.Font = new System.Drawing.Font("Segoe UI", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.vastausBT.Location = new System.Drawing.Point(1062, 98);
            this.vastausBT.Name = "vastausBT";
            this.vastausBT.Size = new System.Drawing.Size(217, 84);
            this.vastausBT.TabIndex = 5;
            this.vastausBT.Text = "Laske";
            this.vastausBT.UseVisualStyleBackColor = true;
            this.vastausBT.Click += new System.EventHandler(this.vastausBT_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1504, 677);
            this.Controls.Add(this.vastausBT);
            this.Controls.Add(this.vastausLB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.merkkiCB);
            this.Controls.Add(this.luku2TB);
            this.Controls.Add(this.luku1TB);
            this.Name = "Form1";
            this.Text = "Harjoitus3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox luku1TB;
        private TextBox luku2TB;
        private ComboBox merkkiCB;
        private Label label1;
        private Label vastausLB;
        private Button vastausBT;
    }
}