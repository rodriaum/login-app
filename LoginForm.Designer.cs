namespace Login
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            loginPictureBox = new PictureBox();
            userTextBox = new TextBox();
            passwordTextBox = new TextBox();
            loginButton = new Button();
            loginLabel = new Label();
            userDebugLabel = new Label();
            passwordDebugLabel = new Label();
            loginDebugLabel = new Label();
            registerButton = new Button();
            ((System.ComponentModel.ISupportInitialize)loginPictureBox).BeginInit();
            SuspendLayout();
            // 
            // loginPictureBox
            // 
            loginPictureBox.Image = (Image)resources.GetObject("loginPictureBox.Image");
            loginPictureBox.Location = new Point(58, 50);
            loginPictureBox.Name = "loginPictureBox";
            loginPictureBox.Size = new Size(347, 307);
            loginPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            loginPictureBox.TabIndex = 3;
            loginPictureBox.TabStop = false;
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
            userTextBox.TextChanged += userTextBox_TextChanged;
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
            passwordTextBox.TextChanged += passwordTextBox_TextChanged;
            // 
            // loginButton
            // 
            loginButton.BackColor = Color.Gainsboro;
            loginButton.BackgroundImage = (Image)resources.GetObject("loginButton.BackgroundImage");
            loginButton.BackgroundImageLayout = ImageLayout.None;
            loginButton.FlatStyle = FlatStyle.Popup;
            loginButton.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            loginButton.ForeColor = SystemColors.Menu;
            loginButton.Location = new Point(121, 265);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(222, 42);
            loginButton.TabIndex = 8;
            loginButton.Text = "Login";
            loginButton.UseVisualStyleBackColor = false;
            loginButton.Click += loginButton_Click;
            // 
            // loginLabel
            // 
            loginLabel.AutoSize = true;
            loginLabel.Font = new Font("Times New Roman", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            loginLabel.ForeColor = Color.DarkOrchid;
            loginLabel.Location = new Point(177, 99);
            loginLabel.Name = "loginLabel";
            loginLabel.Size = new Size(109, 32);
            loginLabel.TabIndex = 9;
            loginLabel.Text = "LOGIN";
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
            loginDebugLabel.Location = new Point(88, 330);
            loginDebugLabel.Name = "loginDebugLabel";
            loginDebugLabel.Size = new Size(0, 17);
            loginDebugLabel.TabIndex = 16;
            loginDebugLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // registerButton
            // 
            registerButton.BackColor = SystemColors.Menu;
            registerButton.FlatStyle = FlatStyle.Flat;
            registerButton.Font = new Font("Segoe UI", 7F);
            registerButton.Location = new Point(121, 306);
            registerButton.Name = "registerButton";
            registerButton.Size = new Size(222, 21);
            registerButton.TabIndex = 17;
            registerButton.Text = "Registro";
            registerButton.UseVisualStyleBackColor = false;
            registerButton.Click += registerButton_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(457, 411);
            Controls.Add(registerButton);
            Controls.Add(loginDebugLabel);
            Controls.Add(passwordDebugLabel);
            Controls.Add(userDebugLabel);
            Controls.Add(loginLabel);
            Controls.Add(loginButton);
            Controls.Add(passwordTextBox);
            Controls.Add(userTextBox);
            Controls.Add(loginPictureBox);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)loginPictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox loginPictureBox;
        private TextBox userTextBox;
        private TextBox passwordTextBox;
        private Button loginButton;
        private Label loginLabel;
        private Label userDebugLabel;
        private Label passwordDebugLabel;
        private Label loginDebugLabel;
        private Button registerButton;
    }
}
