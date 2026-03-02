namespace Pusheen
{
    partial class Form13
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form13));
            label1 = new Label();
            pictureBox2 = new PictureBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            progressBar1 = new ProgressBar();
            label2 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("MV Boli", 50.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(231, 27);
            label1.Name = "label1";
            label1.Size = new Size(289, 87);
            label1.TabIndex = 17;
            label1.Text = "Sleeping";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(208, 106);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(385, 238);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 26;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Myanmar Text", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(599, 27);
            label7.Name = "label7";
            label7.Size = new Size(184, 114);
            label7.TabIndex = 30;
            label7.Text = "+0.1";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Myanmar Text", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(19, 287);
            label6.Name = "label6";
            label6.Size = new Size(184, 114);
            label6.TabIndex = 29;
            label6.Text = "+0.3";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Myanmar Text", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(-9, 50);
            label5.Name = "label5";
            label5.Size = new Size(184, 114);
            label5.TabIndex = 28;
            label5.Text = "+0.1";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Myanmar Text", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(625, 175);
            label4.Name = "label4";
            label4.Size = new Size(184, 114);
            label4.TabIndex = 27;
            label4.Text = "+0.4";
            label4.Click += label4_Click;
            // 
            // progressBar1
            // 
            progressBar1.BackColor = SystemColors.ActiveBorder;
            progressBar1.Location = new Point(179, 378);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(436, 60);
            progressBar1.TabIndex = 31;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("MV Boli", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(625, 378);
            label2.Name = "label2";
            label2.Size = new Size(97, 63);
            label2.TabIndex = 32;
            label2.Text = "0%";
            // 
            // Form13
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(progressBar1);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(pictureBox2);
            Controls.Add(label1);
            Name = "Form13";
            Text = "Form13";
            Load += Form13_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox2;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private ProgressBar progressBar1;
        private Label label2;
        private System.Windows.Forms.Timer timer1;
    }
}