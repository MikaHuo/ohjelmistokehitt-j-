namespace crosshair
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            crossPB = new PictureBox();
            changeGB = new GroupBox();
            button1 = new Button();
            yellowRB = new RadioButton();
            blueRB = new RadioButton();
            greenRB = new RadioButton();
            redRB = new RadioButton();
            crossCB = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)crossPB).BeginInit();
            changeGB.SuspendLayout();
            SuspendLayout();
            // 
            // crossPB
            // 
            crossPB.BackColor = Color.LightGreen;
            crossPB.BackgroundImageLayout = ImageLayout.None;
            crossPB.Image = Properties.Resources._1280px_Rangefinder_reticle_08a1;
            crossPB.Location = new Point(1232, 752);
            crossPB.Name = "crossPB";
            crossPB.Size = new Size(100, 100);
            crossPB.SizeMode = PictureBoxSizeMode.StretchImage;
            crossPB.TabIndex = 1;
            crossPB.TabStop = false;
            crossPB.Click += crossPB_Click;
            // 
            // changeGB
            // 
            changeGB.BackColor = Color.Ivory;
            changeGB.BackgroundImage = (Image)resources.GetObject("changeGB.BackgroundImage");
            changeGB.Controls.Add(button1);
            changeGB.Controls.Add(yellowRB);
            changeGB.Controls.Add(blueRB);
            changeGB.Controls.Add(greenRB);
            changeGB.Controls.Add(redRB);
            changeGB.Controls.Add(crossCB);
            changeGB.Dock = DockStyle.Right;
            changeGB.Location = new Point(1209, 0);
            changeGB.Name = "changeGB";
            changeGB.Size = new Size(400, 835);
            changeGB.TabIndex = 2;
            changeGB.TabStop = false;
            changeGB.Visible = false;
            // 
            // button1
            // 
            button1.Location = new Point(339, 12);
            button1.Name = "button1";
            button1.Size = new Size(49, 46);
            button1.TabIndex = 5;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // yellowRB
            // 
            yellowRB.AutoSize = true;
            yellowRB.Location = new Point(45, 96);
            yellowRB.Name = "yellowRB";
            yellowRB.Size = new Size(112, 36);
            yellowRB.TabIndex = 4;
            yellowRB.TabStop = true;
            yellowRB.Text = "Yellow";
            yellowRB.UseVisualStyleBackColor = true;
            // 
            // blueRB
            // 
            blueRB.AutoSize = true;
            blueRB.Location = new Point(195, 96);
            blueRB.Name = "blueRB";
            blueRB.Size = new Size(92, 36);
            blueRB.TabIndex = 3;
            blueRB.TabStop = true;
            blueRB.Text = "Blue";
            blueRB.UseVisualStyleBackColor = true;
            // 
            // greenRB
            // 
            greenRB.AutoSize = true;
            greenRB.Location = new Point(195, 54);
            greenRB.Name = "greenRB";
            greenRB.Size = new Size(109, 36);
            greenRB.TabIndex = 2;
            greenRB.TabStop = true;
            greenRB.Text = "Green";
            greenRB.UseVisualStyleBackColor = true;
            // 
            // redRB
            // 
            redRB.AutoSize = true;
            redRB.Location = new Point(45, 54);
            redRB.Name = "redRB";
            redRB.Size = new Size(85, 36);
            redRB.TabIndex = 1;
            redRB.TabStop = true;
            redRB.Text = "Red";
            redRB.UseVisualStyleBackColor = true;
            redRB.CheckedChanged += redRB_CheckedChanged;
            // 
            // crossCB
            // 
            crossCB.DropDownStyle = ComboBoxStyle.DropDownList;
            crossCB.FormattingEnabled = true;
            crossCB.Items.AddRange(new object[] { "1", "2", "3", "4", "5" });
            crossCB.Location = new Point(45, 219);
            crossCB.Name = "crossCB";
            crossCB.Size = new Size(242, 40);
            crossCB.TabIndex = 0;
            crossCB.SelectedIndexChanged += crossCB_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGreen;
            ClientSize = new Size(1609, 835);
            Controls.Add(crossPB);
            Controls.Add(changeGB);
            Cursor = Cursors.No;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            TransparencyKey = Color.LightGreen;
            WindowState = FormWindowState.Maximized;
            Load += Form1_Load;
            KeyPress += Form1_KeyPress;
            ((System.ComponentModel.ISupportInitialize)crossPB).EndInit();
            changeGB.ResumeLayout(false);
            changeGB.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox crossPB;
        private GroupBox changeGB;
        private RadioButton yellowRB;
        private RadioButton blueRB;
        private RadioButton greenRB;
        private RadioButton redRB;
        private ComboBox crossCB;
        private Button button1;
    }
}