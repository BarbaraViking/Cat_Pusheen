namespace Pusheen
{
    partial class chatgpt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(chatgpt));
            inputUser = new CuoreUI.Controls.cuiTextBox();
            pictureBox4 = new PictureBox();
            cuiPictureBox1 = new CuoreUI.Controls.cuiPictureBox();
            buttonSend = new CuoreUI.Controls.cuiPictureBox();
            label1 = new Label();
            time = new CuoreUI.Controls.cuiLabel();
            outputUser = new CuoreUI.Controls.cuiTextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // inputUser
            // 
            inputUser.AccessibleName = "";
            inputUser.BackColor = SystemColors.ButtonFace;
            inputUser.BackgroundColor = Color.WhiteSmoke;
            inputUser.Content = "";
            inputUser.FocusBackgroundColor = Color.White;
            inputUser.FocusImageTint = Color.Violet;
            inputUser.FocusOutlineColor = Color.PapayaWhip;
            inputUser.Font = new Font("Comic Sans MS", 15.25F, FontStyle.Bold);
            inputUser.ForeColor = Color.DimGray;
            inputUser.Image = null;
            inputUser.ImageExpand = new Point(0, 0);
            inputUser.ImageOffset = new Point(0, 0);
            inputUser.Location = new Point(15, 384);
            inputUser.Margin = new Padding(6);
            inputUser.Multiline = false;
            inputUser.Name = "inputUser";
            inputUser.NormalImageTint = Color.White;
            inputUser.OutlineColor = Color.FromArgb(128, 128, 128, 128);
            inputUser.Padding = new Padding(29, 11, 29, 0);
            inputUser.PasswordChar = false;
            inputUser.PlaceholderColor = Color.LightGray;
            inputUser.PlaceholderText = "Write text here ...";
            inputUser.Rounding = new Padding(20);
            inputUser.Size = new Size(705, 51);
            inputUser.TabIndex = 38;
            inputUser.TextOffset = new Size(0, 0);
            inputUser.UnderlinedStyle = true;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(713, 4);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(81, 71);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 44;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox4_Click;
            // 
            // cuiPictureBox1
            // 
            cuiPictureBox1.Content = (Image)resources.GetObject("cuiPictureBox1.Content");
            cuiPictureBox1.ImageTint = Color.White;
            cuiPictureBox1.Location = new Point(6, 15);
            cuiPictureBox1.Margin = new Padding(4, 3, 4, 3);
            cuiPictureBox1.Name = "cuiPictureBox1";
            cuiPictureBox1.OutlineThickness = 1F;
            cuiPictureBox1.PanelOutlineColor = Color.Empty;
            cuiPictureBox1.Rotation = 0;
            cuiPictureBox1.Rounding = new Padding(8);
            cuiPictureBox1.Size = new Size(71, 71);
            cuiPictureBox1.TabIndex = 43;
            // 
            // buttonSend
            // 
            buttonSend.AccessibleName = "";
            buttonSend.Content = (Image)resources.GetObject("buttonSend.Content");
            buttonSend.ImageTint = Color.White;
            buttonSend.Location = new Point(728, 382);
            buttonSend.Margin = new Padding(4, 3, 4, 3);
            buttonSend.Name = "buttonSend";
            buttonSend.OutlineThickness = 1F;
            buttonSend.PanelOutlineColor = Color.Empty;
            buttonSend.Rotation = 0;
            buttonSend.Rounding = new Padding(8);
            buttonSend.Size = new Size(60, 59);
            buttonSend.TabIndex = 42;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Myanmar Text", 30F, FontStyle.Bold);
            label1.Location = new Point(105, 15);
            label1.Name = "label1";
            label1.Size = new Size(241, 71);
            label1.TabIndex = 45;
            label1.Text = "Pusheen AI";
            // 
            // time
            // 
            time.BackColor = Color.NavajoWhite;
            time.Content = "09:42";
            time.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            time.HorizontalAlignment = StringAlignment.Center;
            time.Location = new Point(687, 146);
            time.Margin = new Padding(4, 3, 4, 3);
            time.Name = "time";
            time.Size = new Size(61, 22);
            time.TabIndex = 47;
            time.VerticalAlignment = StringAlignment.Near;
            // 
            // outputUser
            // 
            outputUser.AccessibleName = "";
            outputUser.BackColor = SystemColors.ButtonFace;
            outputUser.BackgroundColor = Color.NavajoWhite;
            outputUser.Content = "";
            outputUser.FocusBackgroundColor = Color.White;
            outputUser.FocusImageTint = Color.Violet;
            outputUser.FocusOutlineColor = Color.PapayaWhip;
            outputUser.Font = new Font("MV Boli", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            outputUser.ForeColor = Color.Black;
            outputUser.Image = null;
            outputUser.ImageExpand = new Point(0, 0);
            outputUser.ImageOffset = new Point(0, 0);
            outputUser.ImeMode = ImeMode.Off;
            outputUser.Location = new Point(443, 101);
            outputUser.Margin = new Padding(6);
            outputUser.Multiline = false;
            outputUser.Name = "outputUser";
            outputUser.NormalImageTint = Color.White;
            outputUser.OutlineColor = Color.FromArgb(128, 128, 128, 128);
            outputUser.Padding = new Padding(34, 21, 34, 0);
            outputUser.PasswordChar = false;
            outputUser.PlaceholderColor = Color.Black;
            outputUser.PlaceholderText = "Text";
            outputUser.Rounding = new Padding(20);
            outputUser.Size = new Size(330, 76);
            outputUser.TabIndex = 46;
            outputUser.TextOffset = new Size(0, 0);
            outputUser.UnderlinedStyle = true;
            // 
            // chatgpt
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(time);
            Controls.Add(outputUser);
            Controls.Add(label1);
            Controls.Add(pictureBox4);
            Controls.Add(cuiPictureBox1);
            Controls.Add(buttonSend);
            Controls.Add(inputUser);
            Name = "chatgpt";
            Text = "chatgpt";
            Load += chatgpt_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CuoreUI.Controls.cuiTextBox inputUser;
        private PictureBox pictureBox4;
        private CuoreUI.Controls.cuiPictureBox cuiPictureBox1;
        private CuoreUI.Controls.cuiPictureBox buttonSend;
        private Label label1;
        private CuoreUI.Controls.cuiLabel time;
        private CuoreUI.Controls.cuiTextBox outputUser;
    }
}