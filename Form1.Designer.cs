namespace Login
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
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            whitePictureBox = new PictureBox();
            pictureBox4 = new PictureBox();
            userTextBox = new TextBox();
            passwordTextBox = new TextBox();
            loginButton = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)whitePictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(0, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(799, 450);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(0, 1);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(799, 450);
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // whitePictureBox
            // 
            whitePictureBox.Location = new Point(224, 50);
            whitePictureBox.Name = "whitePictureBox";
            whitePictureBox.Size = new Size(347, 307);
            whitePictureBox.TabIndex = 2;
            whitePictureBox.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(224, 50);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(347, 307);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 3;
            pictureBox4.TabStop = false;
            // 
            // userTextBox
            // 
            userTextBox.BackColor = SystemColors.Menu;
            userTextBox.BorderStyle = BorderStyle.None;
            userTextBox.Font = new Font("Trebuchet MS", 11F);
            userTextBox.ForeColor = Color.DimGray;
            userTextBox.Location = new Point(287, 169);
            userTextBox.Name = "userTextBox";
            userTextBox.Size = new Size(222, 18);
            userTextBox.TabIndex = 7;
            userTextBox.Text = "e-mail";
            // 
            // passwordTextBox
            // 
            passwordTextBox.BackColor = SystemColors.Menu;
            passwordTextBox.BorderStyle = BorderStyle.None;
            passwordTextBox.Font = new Font("Trebuchet MS", 11F);
            passwordTextBox.ForeColor = Color.DimGray;
            passwordTextBox.Location = new Point(287, 220);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(222, 18);
            passwordTextBox.TabIndex = 7;
            passwordTextBox.Text = "password";
            passwordTextBox.TextChanged += textBox2_TextChanged;
            // 
            // loginButton
            // 
            loginButton.BackColor = Color.Gainsboro;
            loginButton.BackgroundImageLayout = ImageLayout.None;
            loginButton.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            loginButton.Location = new Point(287, 269);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(222, 42);
            loginButton.TabIndex = 8;
            loginButton.Text = "Login";
            loginButton.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkOrchid;
            label1.Location = new Point(345, 97);
            label1.Name = "label1";
            label1.Size = new Size(109, 32);
            label1.TabIndex = 9;
            label1.Text = "LOGIN";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(783, 411);
            Controls.Add(label1);
            Controls.Add(loginButton);
            Controls.Add(passwordTextBox);
            Controls.Add(userTextBox);
            Controls.Add(pictureBox4);
            Controls.Add(whitePictureBox);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)whitePictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox whitePictureBox;
        private PictureBox pictureBox4;
        private TextBox userTextBox;
        private TextBox passwordTextBox;
        private Button loginButton;
        private Label label1;
    }
}
