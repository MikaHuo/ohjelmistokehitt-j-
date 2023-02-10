namespace Munakello_teht_16
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
            this.pysaytaBT = new System.Windows.Forms.Button();
            this.käynnistäBT = new System.Windows.Forms.Button();
            this.minCB = new System.Windows.Forms.ComboBox();
            this.sekCB = new System.Windows.Forms.ComboBox();
            this.aikaLB = new System.Windows.Forms.Label();
            this.aikaTM = new System.Windows.Forms.Timer(this.components);
            this.annettuLB = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pysaytaBT
            // 
            this.pysaytaBT.Location = new System.Drawing.Point(436, 216);
            this.pysaytaBT.Margin = new System.Windows.Forms.Padding(4);
            this.pysaytaBT.Name = "pysaytaBT";
            this.pysaytaBT.Size = new System.Drawing.Size(219, 60);
            this.pysaytaBT.TabIndex = 0;
            this.pysaytaBT.Text = "Pysäytä";
            this.pysaytaBT.UseVisualStyleBackColor = true;
            this.pysaytaBT.Click += new System.EventHandler(this.pysaytaBT_Click);
            // 
            // käynnistäBT
            // 
            this.käynnistäBT.Location = new System.Drawing.Point(436, 148);
            this.käynnistäBT.Margin = new System.Windows.Forms.Padding(4);
            this.käynnistäBT.Name = "käynnistäBT";
            this.käynnistäBT.Size = new System.Drawing.Size(219, 60);
            this.käynnistäBT.TabIndex = 1;
            this.käynnistäBT.Text = "Käynnistä";
            this.käynnistäBT.UseVisualStyleBackColor = true;
            this.käynnistäBT.Click += new System.EventHandler(this.käynnistäBT_Click);
            // 
            // minCB
            // 
            this.minCB.FormattingEnabled = true;
            this.minCB.Location = new System.Drawing.Point(44, 158);
            this.minCB.Margin = new System.Windows.Forms.Padding(4);
            this.minCB.Name = "minCB";
            this.minCB.Size = new System.Drawing.Size(352, 50);
            this.minCB.TabIndex = 2;
            this.minCB.Text = "Minuutit";
            // 
            // sekCB
            // 
            this.sekCB.FormattingEnabled = true;
            this.sekCB.Location = new System.Drawing.Point(44, 79);
            this.sekCB.Margin = new System.Windows.Forms.Padding(4);
            this.sekCB.Name = "sekCB";
            this.sekCB.Size = new System.Drawing.Size(352, 50);
            this.sekCB.TabIndex = 3;
            this.sekCB.Text = "Sekunnit";
            // 
            // aikaLB
            // 
            this.aikaLB.AutoSize = true;
            this.aikaLB.Font = new System.Drawing.Font("Tempus Sans ITC", 22.125F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.aikaLB.Location = new System.Drawing.Point(446, 56);
            this.aikaLB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.aikaLB.Name = "aikaLB";
            this.aikaLB.Size = new System.Drawing.Size(209, 77);
            this.aikaLB.TabIndex = 4;
            this.aikaLB.Text = "00:00\r\n";
            // 
            // aikaTM
            // 
            this.aikaTM.Interval = 1000;
            this.aikaTM.Tick += new System.EventHandler(this.aikaTM_Tick);
            // 
            // annettuLB
            // 
            this.annettuLB.AutoSize = true;
            this.annettuLB.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.annettuLB.Location = new System.Drawing.Point(44, 234);
            this.annettuLB.Name = "annettuLB";
            this.annettuLB.Size = new System.Drawing.Size(98, 42);
            this.annettuLB.TabIndex = 5;
            this.annettuLB.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 42F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 306);
            this.Controls.Add(this.annettuLB);
            this.Controls.Add(this.aikaLB);
            this.Controls.Add(this.sekCB);
            this.Controls.Add(this.minCB);
            this.Controls.Add(this.käynnistäBT);
            this.Controls.Add(this.pysaytaBT);
            this.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Munakello";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button pysaytaBT;
        private Button käynnistäBT;
        private ComboBox minCB;
        private ComboBox sekCB;
        private Label aikaLB;
        private System.Windows.Forms.Timer aikaTM;
        private Label annettuLB;
    }
}