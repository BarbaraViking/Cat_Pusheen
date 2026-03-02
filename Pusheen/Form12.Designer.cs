namespace Pusheen
{
    partial class Form12
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form12));
            label2 = new Label();
            pictureBox3 = new PictureBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            pictureBox4 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("MV Boli", 40.25F, FontStyle.Bold | FontStyle.Italic);
            label2.Location = new Point(288, 9);
            label2.Name = "label2";
            label2.Size = new Size(171, 70);
            label2.TabIndex = 14;
            label2.Text = "Books";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(29, 149);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(357, 221);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 22;
            pictureBox3.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("MV Boli", 15.25F, FontStyle.Bold | FontStyle.Italic);
            label1.Location = new Point(63, 108);
            label1.Name = "label1";
            label1.Size = new Size(266, 56);
            label1.TabIndex = 23;
            label1.Text = "Detective investigation:\r\n who ate the cookies? ";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(416, 149);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(357, 221);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 24;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("MV Boli", 15.25F, FontStyle.Bold | FontStyle.Italic);
            label3.Location = new Point(472, 108);
            label3.Name = "label3";
            label3.Size = new Size(266, 56);
            label3.TabIndex = 25;
            label3.Text = "Detective investigation:\r\n where is the crystal?";
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(724, -5);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(81, 71);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 26;
            pictureBox4.TabStop = false;
            // 
            // Form12
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox4);
            Controls.Add(label3);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(pictureBox3);
            Controls.Add(label2);
            Name = "Form12";
            Text = "Form12";
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private PictureBox pictureBox3;
        private Label label1;
        private PictureBox pictureBox1;
        private Label label3;
        private PictureBox pictureBox4;
    }
}