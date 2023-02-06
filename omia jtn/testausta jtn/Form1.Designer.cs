namespace testausta_jtn
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
            this.BT = new System.Windows.Forms.Button();
            this.tekstiLB = new System.Windows.Forms.Label();
            this.TB1 = new System.Windows.Forms.TextBox();
            this.TB2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BT
            // 
            this.BT.Location = new System.Drawing.Point(600, 224);
            this.BT.Name = "BT";
            this.BT.Size = new System.Drawing.Size(150, 46);
            this.BT.TabIndex = 0;
            this.BT.Text = "button1";
            this.BT.UseVisualStyleBackColor = true;
            this.BT.Click += new System.EventHandler(this.button1_Click);
            // 
            // tekstiLB
            // 
            this.tekstiLB.AutoSize = true;
            this.tekstiLB.Location = new System.Drawing.Point(473, 161);
            this.tekstiLB.Name = "tekstiLB";
            this.tekstiLB.Size = new System.Drawing.Size(78, 32);
            this.tekstiLB.TabIndex = 1;
            this.tekstiLB.Text = "label1";
            // 
            // TB1
            // 
            this.TB1.Location = new System.Drawing.Point(335, 231);
            this.TB1.Name = "TB1";
            this.TB1.Size = new System.Drawing.Size(200, 39);
            this.TB1.TabIndex = 2;
            // 
            // TB2
            // 
            this.TB2.Location = new System.Drawing.Point(351, 304);
            this.TB2.Name = "TB2";
            this.TB2.Size = new System.Drawing.Size(200, 39);
            this.TB2.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::testausta_jtn.Properties.Resources.The_Four_Seasons_by_Yehouda_Chaki;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1652, 645);
            this.Controls.Add(this.TB2);
            this.Controls.Add(this.TB1);
            this.Controls.Add(this.tekstiLB);
            this.Controls.Add(this.BT);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button BT;
        private Label tekstiLB;
        private TextBox TB1;
        private TextBox TB2;
    }
}