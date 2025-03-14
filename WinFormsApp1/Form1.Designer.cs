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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            button2 = new Button();
            label2 = new Label();
            progressBar1 = new ProgressBar();
            label3 = new Label();
            button3 = new Button();
            label4 = new Label();
            label5 = new Label();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            label6 = new Label();
            richTextBox1 = new RichTextBox();
            button5 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(255, 128, 0);
            label1.Location = new Point(110, 9);
            label1.Name = "label1";
            label1.Size = new Size(286, 32);
            label1.TabIndex = 0;
            label1.Text = "Steam Manifest Injector";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(192, 255, 255);
            button1.Location = new Point(12, 90);
            button1.Name = "button1";
            button1.Size = new Size(105, 24);
            button1.TabIndex = 1;
            button1.Text = "- Inject Manifest -";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.Location = new Point(-70, 417);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(830, 28);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.Location = new Point(-137, 44);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(848, 15);
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(128, 255, 128);
            button2.Location = new Point(272, 388);
            button2.Name = "button2";
            button2.Size = new Size(107, 23);
            button2.TabIndex = 4;
            button2.Text = "- Open Steam -";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(0, 0, 64);
            label2.Font = new Font("Segoe UI Emoji", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Image = (Image)resources.GetObject("label2.Image");
            label2.Location = new Point(110, 417);
            label2.Name = "label2";
            label2.Size = new Size(269, 17);
            label2.TabIndex = 6;
            label2.Text = "Supported Files : .acf / .manifest / .lua";
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(12, 388);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(121, 23);
            progressBar1.TabIndex = 7;
            progressBar1.Click += progressBar1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 8F, FontStyle.Bold);
            label3.ForeColor = Color.Yellow;
            label3.Location = new Point(27, 372);
            label3.Name = "label3";
            label3.Size = new Size(85, 13);
            label3.TabIndex = 8;
            label3.Text = "Manifest Status";
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(255, 128, 128);
            button3.Location = new Point(385, 388);
            button3.Name = "button3";
            button3.Size = new Size(107, 23);
            button3.TabIndex = 9;
            button3.Text = "- Close Steam -";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI Emoji", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(255, 128, 0);
            label4.Location = new Point(324, 368);
            label4.Name = "label4";
            label4.Size = new Size(123, 17);
            label4.TabIndex = 10;
            label4.Text = "- Steam Program";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI Emoji", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(255, 128, 0);
            label5.Location = new Point(27, 65);
            label5.Name = "label5";
            label5.Size = new Size(90, 17);
            label5.TabIndex = 11;
            label5.Text = "- Inject Tool";
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImage = (Image)resources.GetObject("pictureBox3.BackgroundImage");
            pictureBox3.Location = new Point(12, 65);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(19, 20);
            pictureBox3.TabIndex = 12;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.BackgroundImage = (Image)resources.GetObject("pictureBox4.BackgroundImage");
            pictureBox4.Location = new Point(299, 368);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(19, 20);
            pictureBox4.TabIndex = 13;
            pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.BackgroundImage = (Image)resources.GetObject("pictureBox5.BackgroundImage");
            pictureBox5.Location = new Point(139, 391);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(19, 20);
            pictureBox5.TabIndex = 14;
            pictureBox5.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Red;
            label6.Location = new Point(372, 65);
            label6.Name = "label6";
            label6.Size = new Size(56, 21);
            label6.TabIndex = 15;
            label6.Text = "About";
            // 
            // richTextBox1
            // 
            richTextBox1.Anchor = AnchorStyles.Bottom;
            richTextBox1.Location = new Point(324, 92);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.ReadOnly = true;
            richTextBox1.Size = new Size(161, 96);
            richTextBox1.TabIndex = 16;
            richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(192, 255, 255);
            button5.Location = new Point(12, 120);
            button5.Name = "button5";
            button5.Size = new Size(105, 24);
            button5.TabIndex = 18;
            button5.Text = "- Inject Acf -";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(497, 443);
            Controls.Add(button5);
            Controls.Add(richTextBox1);
            Controls.Add(label6);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(button3);
            Controls.Add(label3);
            Controls.Add(progressBar1);
            Controls.Add(label2);
            Controls.Add(button2);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            Controls.Add(label1);
            MaximumSize = new Size(513, 482);
            MinimumSize = new Size(513, 482);
            Name = "Form1";
            Text = "SMI - Manifest Injector | v1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Button button2;
        private Label label2;
        private ProgressBar progressBar1;
        private Label label3;
        private Button button3;
        private Label label4;
        private Label label5;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private Label label6;
        private RichTextBox richTextBox1;
        private Button button5;
    }
}
