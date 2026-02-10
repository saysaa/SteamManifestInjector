namespace WinFormsApp1
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

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            pictureBox1 = new PictureBox();
            button2 = new Button();
            progressBar1 = new ProgressBar();
            button3 = new Button();
            pictureBox4 = new PictureBox();
            pictureBox6 = new PictureBox();
            label6 = new Label();
            panel1 = new Panel();
            GitHub_link_button = new LinkLabel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(255, 128, 0);
            label1.Location = new Point(112, 9);
            label1.Name = "label1";
            label1.Size = new Size(286, 32);
            label1.TabIndex = 0;
            label1.Text = "Steam Manifest Injector";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.Location = new Point(-71, 404);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(835, 49);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(128, 255, 128);
            button2.Location = new Point(265, 404);
            button2.Name = "button2";
            button2.Size = new Size(107, 36);
            button2.TabIndex = 4;
            button2.Text = "- Open Steam -";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(12, 404);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(179, 36);
            progressBar1.TabIndex = 7;
            progressBar1.Click += progressBar1_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(255, 128, 128);
            button3.Location = new Point(378, 404);
            button3.Name = "button3";
            button3.Size = new Size(107, 36);
            button3.TabIndex = 9;
            button3.Text = "- Close Steam -";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.Transparent;
            pictureBox4.BackgroundImage = (Image)resources.GetObject("pictureBox4.BackgroundImage");
            pictureBox4.Location = new Point(466, 380);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(19, 20);
            pictureBox4.TabIndex = 13;
            pictureBox4.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.BackColor = Color.FromArgb(64, 64, 64);
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(12, 87);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(473, 287);
            pictureBox6.TabIndex = 19;
            pictureBox6.TabStop = false;
            pictureBox6.Click += pictureBox6_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Microsoft Sans Serif", 9.749999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Red;
            label6.Location = new Point(12, 380);
            label6.Name = "label6";
            label6.Size = new Size(93, 16);
            label6.TabIndex = 20;
            label6.Text = "Drag your files";
            label6.Click += label6_Click;
            // 
            // panel1
            // 
            panel1.Location = new Point(12, 71);
            panel1.Name = "panel1";
            panel1.Size = new Size(473, 10);
            panel1.TabIndex = 21;
            // 
            // GitHub_link_button
            // 
            GitHub_link_button.ActiveLinkColor = Color.FromArgb(0, 192, 0);
            GitHub_link_button.AutoSize = true;
            GitHub_link_button.BackColor = Color.Transparent;
            GitHub_link_button.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            GitHub_link_button.LinkColor = Color.FromArgb(192, 64, 0);
            GitHub_link_button.Location = new Point(229, 41);
            GitHub_link_button.Name = "GitHub_link_button";
            GitHub_link_button.Size = new Size(51, 16);
            GitHub_link_button.TabIndex = 22;
            GitHub_link_button.TabStop = true;
            GitHub_link_button.Text = "Github";
            GitHub_link_button.LinkClicked += GitHub_link_button_LinkClicked;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(497, 443);
            Controls.Add(GitHub_link_button);
            Controls.Add(panel1);
            Controls.Add(label6);
            Controls.Add(pictureBox6);
            Controls.Add(pictureBox4);
            Controls.Add(button3);
            Controls.Add(progressBar1);
            Controls.Add(button2);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            MaximumSize = new Size(513, 482);
            MinimumSize = new Size(513, 482);
            Name = "Form1";
            Text = "SteamManifestInjector - v3";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #region Windows Form Designer generated code

        // Removed duplicate InitializeComponent method

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private Button button2;
        private ProgressBar progressBar1;
        private Button button3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox6;
        private Label label6;
        private Panel panel1;
        private LinkLabel GitHub_link_button;
    }
}
