namespace Pusheen
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            label1 = new Label();
            label2 = new Label();
            pictureBox2 = new PictureBox();
            label3 = new Label();
            pictureBox3 = new PictureBox();
            pictureBox1 = new PictureBox();
            label4 = new Label();
            pictureBox4 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("MV Boli", 35.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(303, 9);
            label1.Name = "label1";
            label1.Size = new Size(169, 62);
            label1.TabIndex = 0;
            label1.Text = "Games";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("MV Boli", 15F, FontStyle.Bold | FontStyle.Italic);
            label2.Location = new Point(65, 271);
            label2.Name = "label2";
            label2.Size = new Size(157, 26);
            label2.TabIndex = 2;
            label2.Text = "Ice cream ball";
            label2.Click += label2_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(260, 104);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(264, 163);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("MV Boli", 15F, FontStyle.Bold | FontStyle.Italic);
            label3.Location = new Point(598, 270);
            label3.Name = "label3";
            label3.Size = new Size(145, 26);
            label3.TabIndex = 4;
            label3.Text = "Popping balls";
            label3.Click += label3_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(530, 95);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(264, 172);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 5;
            pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 95);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(264, 179);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("MV Boli", 15F, FontStyle.Bold | FontStyle.Italic);
            label4.Location = new Point(333, 270);
            label4.Name = "label4";
            label4.Size = new Size(146, 26);
            label4.TabIndex = 7;
            label4.Text = "collect image";
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(723, 0);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(81, 71);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 8;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox4_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Linen;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox4);
            Controls.Add(label4);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox3);
            Controls.Add(label3);
            Controls.Add(pictureBox2);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form3";
            Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private PictureBox pictureBox2;
        private Label label3;
        private PictureBox pictureBox3;
        private PictureBox pictureBox1;
        private Label label4;
        private PictureBox pictureBox4;
    }
}