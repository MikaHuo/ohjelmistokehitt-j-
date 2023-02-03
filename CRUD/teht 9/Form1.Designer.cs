namespace teht_9
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.fahBT = new System.Windows.Forms.RadioButton();
            this.celsiusBT = new System.Windows.Forms.RadioButton();
            this.muunnaBT = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.syottoTB = new System.Windows.Forms.TextBox();
            this.vastausLB = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.fahBT);
            this.groupBox1.Controls.Add(this.celsiusBT);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(741, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(400, 200);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mihin haluat muuttaa?";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // fahBT
            // 
            this.fahBT.AutoSize = true;
            this.fahBT.Location = new System.Drawing.Point(38, 127);
            this.fahBT.Name = "fahBT";
            this.fahBT.Size = new System.Drawing.Size(200, 49);
            this.fahBT.TabIndex = 1;
            this.fahBT.TabStop = true;
            this.fahBT.Text = "Fahrenheit";
            this.fahBT.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.fahBT.UseVisualStyleBackColor = true;
            // 
            // celsiusBT
            // 
            this.celsiusBT.AutoSize = true;
            this.celsiusBT.Location = new System.Drawing.Point(38, 63);
            this.celsiusBT.Name = "celsiusBT";
            this.celsiusBT.Size = new System.Drawing.Size(150, 49);
            this.celsiusBT.TabIndex = 0;
            this.celsiusBT.TabStop = true;
            this.celsiusBT.Text = "Celsius";
            this.celsiusBT.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.celsiusBT.UseVisualStyleBackColor = true;
            // 
            // muunnaBT
            // 
            this.muunnaBT.BackColor = System.Drawing.SystemColors.ControlLight;
            this.muunnaBT.Font = new System.Drawing.Font("Segoe UI", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.muunnaBT.Location = new System.Drawing.Point(840, 300);
            this.muunnaBT.Margin = new System.Windows.Forms.Padding(7);
            this.muunnaBT.Name = "muunnaBT";
            this.muunnaBT.Size = new System.Drawing.Size(236, 75);
            this.muunnaBT.TabIndex = 1;
            this.muunnaBT.Text = "Muunna";
            this.muunnaBT.UseVisualStyleBackColor = false;
            this.muunnaBT.Click += new System.EventHandler(this.muunnaBT_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(75, 313);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 45);
            this.label1.TabIndex = 3;
            this.label1.Text = "Vastaus:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(75, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(270, 45);
            this.label2.TabIndex = 4;
            this.label2.Text = "Anna muutettava:";
            // 
            // syottoTB
            // 
            this.syottoTB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.syottoTB.Location = new System.Drawing.Point(378, 148);
            this.syottoTB.Name = "syottoTB";
            this.syottoTB.Size = new System.Drawing.Size(200, 50);
            this.syottoTB.TabIndex = 5;
            this.syottoTB.Text = "9";
            // 
            // vastausLB
            // 
            this.vastausLB.AutoSize = true;
            this.vastausLB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.vastausLB.Location = new System.Drawing.Point(265, 313);
            this.vastausLB.Name = "vastausLB";
            this.vastausLB.Size = new System.Drawing.Size(80, 45);
            this.vastausLB.TabIndex = 6;
            this.vastausLB.Text = "xxxx";
            this.vastausLB.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::teht_9.Properties.Resources.The_Four_Seasons_by_Yehouda_Chaki;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1207, 435);
            this.Controls.Add(this.vastausLB);
            this.Controls.Add(this.syottoTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.muunnaBT);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox groupBox1;
        private RadioButton fahBT;
        private RadioButton celsiusBT;
        private Button muunnaBT;
        private Label label1;
        private Label label2;
        private TextBox syottoTB;
        private Label vastausLB;
    }
}