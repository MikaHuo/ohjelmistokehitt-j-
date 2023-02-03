namespace harj_8
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
            this.otsikkoLB = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.vastausLB = new System.Windows.Forms.Label();
            this.muutaBT = new System.Windows.Forms.Button();
            this.textbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // otsikkoLB
            // 
            this.otsikkoLB.AutoSize = true;
            this.otsikkoLB.Font = new System.Drawing.Font("Snap ITC", 25.875F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.otsikkoLB.Location = new System.Drawing.Point(307, 37);
            this.otsikkoLB.Name = "otsikkoLB";
            this.otsikkoLB.Size = new System.Drawing.Size(874, 89);
            this.otsikkoLB.TabIndex = 0;
            this.otsikkoLB.Text = "Roomalaiset numerot";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Viner Hand ITC", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 237);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1066, 69);
            this.label2.TabIndex = 1;
            this.label2.Text = "Anna numero 1-3999 niin muutan sen roomalaisiksi.";
            // 
            // vastausLB
            // 
            this.vastausLB.AutoSize = true;
            this.vastausLB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.vastausLB.Location = new System.Drawing.Point(107, 396);
            this.vastausLB.Name = "vastausLB";
            this.vastausLB.Size = new System.Drawing.Size(0, 45);
            this.vastausLB.TabIndex = 2;
            // 
            // muutaBT
            // 
            this.muutaBT.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.muutaBT.Location = new System.Drawing.Point(1184, 375);
            this.muutaBT.Name = "muutaBT";
            this.muutaBT.Size = new System.Drawing.Size(161, 67);
            this.muutaBT.TabIndex = 3;
            this.muutaBT.Text = "Muuta";
            this.muutaBT.UseVisualStyleBackColor = true;
            this.muutaBT.Click += new System.EventHandler(this.muutaBT_Click);
            // 
            // textbox
            // 
            this.textbox.Location = new System.Drawing.Point(1162, 251);
            this.textbox.Name = "textbox";
            this.textbox.Size = new System.Drawing.Size(200, 39);
            this.textbox.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1523, 686);
            this.Controls.Add(this.textbox);
            this.Controls.Add(this.muutaBT);
            this.Controls.Add(this.vastausLB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.otsikkoLB);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label otsikkoLB;
        private Label label2;
        private Label vastausLB;
        private Button muutaBT;
        private TextBox textbox;
    }
}