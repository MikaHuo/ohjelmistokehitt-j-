namespace suosituimmat_nimet
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
            this.nimiTB = new System.Windows.Forms.TextBox();
            this.tarkastaBT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(131, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1044, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "Anna nimesi niin tarkastan onko se 50 suosituimman joukossa.";
            // 
            // vastausLB
            // 
            this.vastausLB.AutoSize = true;
            this.vastausLB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.vastausLB.Location = new System.Drawing.Point(660, 123);
            this.vastausLB.Name = "vastausLB";
            this.vastausLB.Size = new System.Drawing.Size(105, 45);
            this.vastausLB.TabIndex = 1;
            this.vastausLB.Text = "label2";
            this.vastausLB.Visible = false;
            // 
            // nimiTB
            // 
            this.nimiTB.Font = new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nimiTB.Location = new System.Drawing.Point(131, 106);
            this.nimiTB.Name = "nimiTB";
            this.nimiTB.Size = new System.Drawing.Size(404, 57);
            this.nimiTB.TabIndex = 2;
            // 
            // tarkastaBT
            // 
            this.tarkastaBT.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tarkastaBT.Location = new System.Drawing.Point(131, 197);
            this.tarkastaBT.Name = "tarkastaBT";
            this.tarkastaBT.Size = new System.Drawing.Size(154, 60);
            this.tarkastaBT.TabIndex = 3;
            this.tarkastaBT.Text = "Tarkasta";
            this.tarkastaBT.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
       
        }

        #endregion

        private Label label1;
        private Label vastausLB;
        private TextBox nimiTB;
        private Button tarkastaBT;
    }
}