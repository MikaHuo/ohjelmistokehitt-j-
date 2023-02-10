namespace sekunttikello_teht15
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
            this.components = new System.ComponentModel.Container();
            this.StartBT = new System.Windows.Forms.Button();
            this.resetBT = new System.Windows.Forms.Button();
            this.stopBT = new System.Windows.Forms.Button();
            this.aikaLB = new System.Windows.Forms.Label();
            this.aikaTM = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // StartBT
            // 
            this.StartBT.Font = new System.Drawing.Font("SimSun", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.StartBT.Location = new System.Drawing.Point(38, 112);
            this.StartBT.Name = "StartBT";
            this.StartBT.Size = new System.Drawing.Size(150, 46);
            this.StartBT.TabIndex = 0;
            this.StartBT.Text = "Start";
            this.StartBT.UseVisualStyleBackColor = true;
            this.StartBT.Click += new System.EventHandler(this.StartBT_Click);
            // 
            // resetBT
            // 
            this.resetBT.Font = new System.Drawing.Font("SimSun", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.resetBT.Location = new System.Drawing.Point(155, 169);
            this.resetBT.Name = "resetBT";
            this.resetBT.Size = new System.Drawing.Size(150, 46);
            this.resetBT.TabIndex = 1;
            this.resetBT.Text = "Reset";
            this.resetBT.UseVisualStyleBackColor = true;
            this.resetBT.Click += new System.EventHandler(this.resetBT_Click);
            // 
            // stopBT
            // 
            this.stopBT.Font = new System.Drawing.Font("SimSun", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.stopBT.Location = new System.Drawing.Point(282, 112);
            this.stopBT.Name = "stopBT";
            this.stopBT.Size = new System.Drawing.Size(150, 46);
            this.stopBT.TabIndex = 2;
            this.stopBT.Text = "Stop";
            this.stopBT.UseVisualStyleBackColor = true;
            this.stopBT.Click += new System.EventHandler(this.stopBT_Click);
            // 
            // aikaLB
            // 
            this.aikaLB.AutoSize = true;
            this.aikaLB.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.aikaLB.Location = new System.Drawing.Point(38, 23);
            this.aikaLB.Name = "aikaLB";
            this.aikaLB.Size = new System.Drawing.Size(394, 86);
            this.aikaLB.TabIndex = 3;
            this.aikaLB.Text = "00:00:00:000";
            // 
            // aikaTM
            // 
            this.aikaTM.Enabled = true;
            this.aikaTM.Interval = 10;
            this.aikaTM.Tick += new System.EventHandler(this.aikaTM_Tick_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 227);
            this.Controls.Add(this.aikaLB);
            this.Controls.Add(this.stopBT);
            this.Controls.Add(this.resetBT);
            this.Controls.Add(this.StartBT);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button StartBT;
        private Button resetBT;
        private Button stopBT;
        private Label aikaLB;
        private System.Windows.Forms.Timer aikaTM;
    }
}