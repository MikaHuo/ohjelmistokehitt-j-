namespace Noppapeli
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.HeitaBT = new System.Windows.Forms.Button();
            this.noppa01PB = new System.Windows.Forms.PictureBox();
            this.noppa02PB = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.noppa01PB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.noppa02PB)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(410, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(383, 79);
            this.label1.TabIndex = 0;
            this.label1.Text = "Noppapeli";
            // 
            // HeitaBT
            // 
            this.HeitaBT.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.HeitaBT.Location = new System.Drawing.Point(515, 422);
            this.HeitaBT.Name = "HeitaBT";
            this.HeitaBT.Size = new System.Drawing.Size(181, 56);
            this.HeitaBT.TabIndex = 1;
            this.HeitaBT.Text = "Pyöräytä";
            this.HeitaBT.UseVisualStyleBackColor = true;
            this.HeitaBT.Click += new System.EventHandler(this.button1_Click);
            // 
            // noppa01PB
            // 
            this.noppa01PB.BackgroundImage = global::Noppapeli.Properties.Resources.dice01;
            this.noppa01PB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.noppa01PB.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.noppa01PB.Location = new System.Drawing.Point(108, 177);
            this.noppa01PB.Name = "noppa01PB";
            this.noppa01PB.Size = new System.Drawing.Size(384, 382);
            this.noppa01PB.TabIndex = 2;
            this.noppa01PB.TabStop = false;
            // 
            // noppa02PB
            // 
            this.noppa02PB.BackgroundImage = global::Noppapeli.Properties.Resources.dice01;
            this.noppa02PB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.noppa02PB.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.noppa02PB.Location = new System.Drawing.Point(715, 177);
            this.noppa02PB.Name = "noppa02PB";
            this.noppa02PB.Size = new System.Drawing.Size(384, 382);
            this.noppa02PB.TabIndex = 3;
            this.noppa02PB.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "dice01.png");
            this.imageList1.Images.SetKeyName(1, "dice02.png");
            this.imageList1.Images.SetKeyName(2, "dice03.png");
            this.imageList1.Images.SetKeyName(3, "dice04.png");
            this.imageList1.Images.SetKeyName(4, "dice05.png");
            this.imageList1.Images.SetKeyName(5, "dice06.png");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1237, 701);
            this.Controls.Add(this.noppa02PB);
            this.Controls.Add(this.noppa01PB);
            this.Controls.Add(this.HeitaBT);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.noppa01PB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.noppa02PB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button HeitaBT;
        private PictureBox noppa01PB;
        private PictureBox noppa02PB;
        private System.Windows.Forms.Timer timer1;
        private ImageList imageList1;
    }
}