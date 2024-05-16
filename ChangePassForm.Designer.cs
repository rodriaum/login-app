namespace Login
{
    partial class ChangePassForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangePassForm));
            confirmEmailPictureBox = new PictureBox();
            passwordTextBox = new TextBox();
            verifyButton = new Button();
            confirmEmailLabel = new Label();
            codeDebugLabel = new Label();
            confirmEmailDebugLabel = new Label();
            returnButton = new Button();
            emailLabel = new Label();
            userPasswordLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)confirmEmailPictureBox).BeginInit();
            SuspendLayout();
            // 
            // confirmEmailPictureBox
            // 
            confirmEmailPictureBox.Image = (Image)resources.GetObject("confirmEmailPictureBox.Image");
            confirmEmailPictureBox.Location = new Point(58, 50);
            confirmEmailPictureBox.Name = "confirmEmailPictureBox";
            confirmEmailPictureBox.Size = new Size(347, 307);
            confirmEmailPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            confirmEmailPictureBox.TabIndex = 3;
            confirmEmailPictureBox.TabStop = false;
            // 
            // passwordTextBox
            // 
            passwordTextBox.BackColor = SystemColors.Menu;
            passwordTextBox.BorderStyle = BorderStyle.None;
            passwordTextBox.Font = new Font("Trebuchet MS", 11F);
            passwordTextBox.ForeColor = Color.DimGray;
            passwordTextBox.Location = new Point(121, 169);
            passwordTextBox.MaxLength = 6;
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(222, 18);
            passwordTextBox.TabIndex = 0;
            // 
            // verifyButton
            // 
            verifyButton.BackColor = Color.Gainsboro;
            verifyButton.BackgroundImageLayout = ImageLayout.None;
            verifyButton.FlatStyle = FlatStyle.Popup;
            verifyButton.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            verifyButton.ForeColor = SystemColors.Menu;
            verifyButton.Image = (Image)resources.GetObject("verifyButton.Image");
            verifyButton.Location = new Point(121, 265);
            verifyButton.Name = "verifyButton";
            verifyButton.Size = new Size(222, 42);
            verifyButton.TabIndex = 8;
            verifyButton.Text = "Alterar";
            verifyButton.UseVisualStyleBackColor = false;
            verifyButton.Click += verifyButton_Click;
            // 
            // confirmEmailLabel
            // 
            confirmEmailLabel.AutoSize = true;
            confirmEmailLabel.Font = new Font("Times New Roman", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            confirmEmailLabel.ForeColor = Color.DarkOrchid;
            confirmEmailLabel.Location = new Point(73, 94);
            confirmEmailLabel.Name = "confirmEmailLabel";
            confirmEmailLabel.Size = new Size(316, 32);
            confirmEmailLabel.TabIndex = 9;
            confirmEmailLabel.Text = "ALTERAR PASSWORD";
            // 
            // codeDebugLabel
            // 
            codeDebugLabel.AutoSize = true;
            codeDebugLabel.Font = new Font("Bahnschrift Condensed", 10F);
            codeDebugLabel.Location = new Point(165, 196);
            codeDebugLabel.Name = "codeDebugLabel";
            codeDebugLabel.Size = new Size(0, 17);
            codeDebugLabel.TabIndex = 14;
            codeDebugLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // confirmEmailDebugLabel
            // 
            confirmEmailDebugLabel.AutoSize = true;
            confirmEmailDebugLabel.Font = new Font("Bahnschrift Condensed", 10F);
            confirmEmailDebugLabel.Location = new Point(88, 330);
            confirmEmailDebugLabel.Name = "confirmEmailDebugLabel";
            confirmEmailDebugLabel.Size = new Size(0, 17);
            confirmEmailDebugLabel.TabIndex = 16;
            confirmEmailDebugLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // returnButton
            // 
            returnButton.BackColor = SystemColors.Menu;
            returnButton.FlatStyle = FlatStyle.Flat;
            returnButton.Font = new Font("Segoe UI", 7F);
            returnButton.Location = new Point(121, 306);
            returnButton.Name = "returnButton";
            returnButton.Size = new Size(222, 21);
            returnButton.TabIndex = 17;
            returnButton.Text = "Voltar para Área Privada";
            returnButton.UseVisualStyleBackColor = false;
            returnButton.Click += returnButton_Click;
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Font = new Font("Times New Roman", 8F, FontStyle.Italic);
            emailLabel.ForeColor = Color.MediumPurple;
            emailLabel.Location = new Point(180, 126);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(0, 14);
            emailLabel.TabIndex = 18;
            emailLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // userPasswordLabel
            // 
            userPasswordLabel.AutoSize = true;
            userPasswordLabel.Font = new Font("Lucida Sans Unicode", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            userPasswordLabel.ForeColor = SystemColors.ControlDarkDark;
            userPasswordLabel.Location = new Point(121, 145);
            userPasswordLabel.Name = "userPasswordLabel";
            userPasswordLabel.Size = new Size(66, 16);
            userPasswordLabel.TabIndex = 18;
            userPasswordLabel.Text = "Password";
            userPasswordLabel.TextAlign = ContentAlignment.BottomCenter;
            // 
            // ChangePassForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(457, 411);
            Controls.Add(emailLabel);
            Controls.Add(returnButton);
            Controls.Add(confirmEmailDebugLabel);
            Controls.Add(codeDebugLabel);
            Controls.Add(confirmEmailLabel);
            Controls.Add(verifyButton);
            Controls.Add(passwordTextBox);
            Controls.Add(userPasswordLabel);
            Controls.Add(confirmEmailPictureBox);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "ChangePassForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Confirmar E-mail";
            ((System.ComponentModel.ISupportInitialize)confirmEmailPictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox confirmEmailPictureBox;
        private TextBox passwordTextBox;
        private Button verifyButton;
        private Label confirmEmailLabel;
        private Label codeDebugLabel;
        private Label confirmEmailDebugLabel;
        private Button returnButton;
        private Label emailLabel;
        private Label userPasswordLabel;
    }
}