using Login.Properties;

namespace Login
{
    partial class PrivateAreaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrivateAreaForm));
            privateAreaPictureBox = new PictureBox();
            usersCheckedListBox = new CheckedListBox();
            removeEmailsButton = new Button();
            exitButton = new Button();
            userLabel = new Label();
            infoLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)privateAreaPictureBox).BeginInit();
            SuspendLayout();
            // 
            // privateAreaPictureBox
            // 
            privateAreaPictureBox.Location = new Point(58, 50);
            privateAreaPictureBox.Name = "privateAreaPictureBox";
            privateAreaPictureBox.Size = new Size(347, 307);
            privateAreaPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            privateAreaPictureBox.TabIndex = 2;
            privateAreaPictureBox.TabStop = false;
            // 
            // usersCheckedListBox
            // 
            usersCheckedListBox.FormattingEnabled = true;
            usersCheckedListBox.Location = new Point(58, 110);
            usersCheckedListBox.Name = "usersCheckedListBox";
            usersCheckedListBox.Size = new Size(347, 202);
            usersCheckedListBox.TabIndex = 3;
            usersCheckedListBox.DoubleClick += usersCheckedListBox_DoubleClick;
            // 
            // removeEmailsButton
            // 
            removeEmailsButton.Location = new Point(58, 315);
            removeEmailsButton.Name = "removeEmailsButton";
            removeEmailsButton.Size = new Size(175, 42);
            removeEmailsButton.TabIndex = 4;
            removeEmailsButton.Text = "Remover E-mails Selecionados";
            removeEmailsButton.UseVisualStyleBackColor = true;
            removeEmailsButton.Click += removeEmailsButton_Click;
            // 
            // exitButton
            // 
            exitButton.Location = new Point(230, 315);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(175, 42);
            exitButton.TabIndex = 5;
            exitButton.Text = "Sair";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // userLabel
            // 
            userLabel.AutoSize = true;
            userLabel.Font = new Font("Times New Roman", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            userLabel.ForeColor = Color.DarkOrchid;
            userLabel.Location = new Point(148, 60);
            userLabel.Name = "userLabel";
            userLabel.Size = new Size(162, 32);
            userLabel.TabIndex = 10;
            userLabel.Text = "USUÁRIOS";
            // 
            // infoLabel
            // 
            infoLabel.AutoSize = true;
            infoLabel.Font = new Font("Times New Roman", 8F, FontStyle.Italic);
            infoLabel.ForeColor = Color.MediumPurple;
            infoLabel.Location = new Point(129, 92);
            infoLabel.Name = "infoLabel";
            infoLabel.Size = new Size(207, 14);
            infoLabel.TabIndex = 11;
            infoLabel.Text = "Clique 2x para alterar password do e-mail.";
            // 
            // PrivateAreaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(457, 411);
            Controls.Add(infoLabel);
            Controls.Add(userLabel);
            Controls.Add(removeEmailsButton);
            Controls.Add(exitButton);
            Controls.Add(usersCheckedListBox);
            Controls.Add(privateAreaPictureBox);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "PrivateAreaForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PrivateAreaForm";
            ((System.ComponentModel.ISupportInitialize)privateAreaPictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox privateAreaPictureBox;
        private CheckedListBox usersCheckedListBox;
        private Button removeEmailsButton;
        private Button exitButton;
        private Label userLabel;
        private Label infoLabel;
    }
}