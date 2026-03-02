namespace Pusheen
{
    partial class Form14
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form14));
            label1 = new Label();
            label2 = new Label();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            pictureBox4 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("MV Boli", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(43, 69);
            label1.Name = "label1";
            label1.Size = new Size(610, 308);
            label1.TabIndex = 17;
            label1.Text = resources.GetString("label1.Text");
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("MV Boli", 20.25F, FontStyle.Bold | FontStyle.Italic);
            label2.Location = new Point(12, 9);
            label2.Name = "label2";
            label2.Size = new Size(651, 34);
            label2.TabIndex = 16;
            label2.Text = "Detective investigation: who ate the cookies? ";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(517, 106);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(264, 227);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 25;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(5, 392);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(104, 59);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 24;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(677, 392);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(104, 59);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 23;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(715, 0);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(81, 71);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 22;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox4_Click;
            // 
            // Form14
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox4);
            Controls.Add(label1);
            Controls.Add(label2);
            Name = "Form14";
            Text = "Form14";
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox4;
    }
}