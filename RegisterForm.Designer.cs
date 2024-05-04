namespace Login
{
    partial class RegisterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
            pictureBox1 = new PictureBox();
            backgroundPictureBox = new PictureBox();
            registerPictureBox = new PictureBox();
            userTextBox = new TextBox();
            passwordTextBox = new TextBox();
            registerButton = new Button();
            registerLabel = new Label();
            userDebugLabel = new Label();
            passwordDebugLabel = new Label();
            loginDebugLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)backgroundPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)registerPictureBox).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(0, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(472, 418);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // backgroundPictureBox
            // 
            backgroundPictureBox.Image = (Image)resources.GetObject("backgroundPictureBox.Image");
            backgroundPictureBox.Location = new Point(0, 1);
            backgroundPictureBox.Name = "backgroundPictureBox";
            backgroundPictureBox.Size = new Size(459, 418);
            backgroundPictureBox.TabIndex = 1;
            backgroundPictureBox.TabStop = false;
            // 
            // registerPictureBox
            // 
            registerPictureBox.Image = (Image)resources.GetObject("registerPictureBox.Image");
            registerPictureBox.Location = new Point(58, 50);
            registerPictureBox.Name = "registerPictureBox";
            registerPictureBox.Size = new Size(347, 307);
            registerPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            registerPictureBox.TabIndex = 3;
            registerPictureBox.TabStop = false;
            // 
            // userTextBox
            // 
            userTextBox.BackColor = SystemColors.Menu;
            userTextBox.BorderStyle = BorderStyle.None;
            userTextBox.Font = new Font("Trebuchet MS", 11F);
            userTextBox.ForeColor = Color.DimGray;
            userTextBox.Location = new Point(121, 169);
            userTextBox.Name = "userTextBox";
            userTextBox.Size = new Size(222, 18);
            userTextBox.TabIndex = 0;
            // 
            // passwordTextBox
            // 
            passwordTextBox.BackColor = SystemColors.Menu;
            passwordTextBox.BorderStyle = BorderStyle.None;
            passwordTextBox.Font = new Font("Trebuchet MS", 11F);
            passwordTextBox.ForeColor = Color.DimGray;
            passwordTextBox.Location = new Point(121, 219);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(222, 18);
            passwordTextBox.TabIndex = 1;
            passwordTextBox.UseSystemPasswordChar = true;
            // 
            // registerButton
            // 
            registerButton.BackColor = Color.Gainsboro;
            registerButton.BackgroundImageLayout = ImageLayout.None;
            registerButton.FlatStyle = FlatStyle.Popup;
            registerButton.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            registerButton.ForeColor = Color.Gainsboro;
            registerButton.Image = (Image)resources.GetObject("registerButton.Image");
            registerButton.Location = new Point(121, 265);
            registerButton.Name = "registerButton";
            registerButton.Size = new Size(222, 42);
            registerButton.TabIndex = 8;
            registerButton.Text = "Registro";
            registerButton.UseVisualStyleBackColor = false;
            // 
            // registerLabel
            // 
            registerLabel.AutoSize = true;
            registerLabel.Font = new Font("Times New Roman", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            registerLabel.ForeColor = Color.DarkOrchid;
            registerLabel.Location = new Point(150, 97);
            registerLabel.Name = "registerLabel";
            registerLabel.Size = new Size(164, 32);
            registerLabel.TabIndex = 9;
            registerLabel.Text = "REGISTRO";
            // 
            // userDebugLabel
            // 
            userDebugLabel.AutoSize = true;
            userDebugLabel.Font = new Font("Bahnschrift Condensed", 10F);
            userDebugLabel.Location = new Point(165, 196);
            userDebugLabel.Name = "userDebugLabel";
            userDebugLabel.Size = new Size(0, 17);
            userDebugLabel.TabIndex = 14;
            userDebugLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // passwordDebugLabel
            // 
            passwordDebugLabel.AutoSize = true;
            passwordDebugLabel.Font = new Font("Bahnschrift Condensed", 10F);
            passwordDebugLabel.Location = new Point(165, 247);
            passwordDebugLabel.Name = "passwordDebugLabel";
            passwordDebugLabel.Size = new Size(0, 17);
            passwordDebugLabel.TabIndex = 15;
            passwordDebugLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // loginDebugLabel
            // 
            loginDebugLabel.AutoSize = true;
            loginDebugLabel.Font = new Font("Bahnschrift Condensed", 10F);
            loginDebugLabel.Location = new Point(88, 310);
            loginDebugLabel.Name = "loginDebugLabel";
            loginDebugLabel.Size = new Size(0, 17);
            loginDebugLabel.TabIndex = 16;
            loginDebugLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(457, 411);
            Controls.Add(loginDebugLabel);
            Controls.Add(passwordDebugLabel);
            Controls.Add(userDebugLabel);
            Controls.Add(registerLabel);
            Controls.Add(registerButton);
            Controls.Add(passwordTextBox);
            Controls.Add(userTextBox);
            Controls.Add(registerPictureBox);
            Controls.Add(backgroundPictureBox);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "RegisterForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registro";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)backgroundPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)registerPictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox backgroundPictureBox;
        private PictureBox loginPictureBox;
        private TextBox userTextBox;
        private TextBox passwordTextBox;
        private Button registerButton;
        private Label loginLabel;
        private Label userDebugLabel;
        private Label passwordDebugLabel;
        private Label loginDebugLabel;
        private PictureBox registerPictureBox;
        private Label registerLabel;
    }
}
