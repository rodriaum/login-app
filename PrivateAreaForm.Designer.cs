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
            userListBox = new ListBox();
            saveButton = new Button();
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
            // userListBox
            // 
            userListBox.FormattingEnabled = true;
            userListBox.ItemHeight = 15;
            userListBox.Location = new Point(58, 110);
            userListBox.Name = "userListBox";
            userListBox.Size = new Size(347, 214);
            userListBox.TabIndex = 3;
            userListBox.Click += userListBox_Click;
            userListBox.DoubleClick += userListBox_DoubleClick;
            // 
            // saveButton
            // 
            saveButton.Location = new Point(58, 315);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(175, 42);
            saveButton.TabIndex = 4;
            saveButton.Text = "Guardar Alterações";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
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
            infoLabel.Location = new Point(120, 92);
            infoLabel.Name = "infoLabel";
            infoLabel.Size = new Size(225, 14);
            infoLabel.TabIndex = 11;
            infoLabel.Text = "Clique 2x para remover, 1x para alterar senha.";
            // 
            // PrivateAreaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(457, 411);
            Controls.Add(infoLabel);
            Controls.Add(userLabel);
            Controls.Add(saveButton);
            Controls.Add(exitButton);
            Controls.Add(userListBox);
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
        private ListBox userListBox;
        private Button saveButton;
        private Button exitButton;
        private Label userLabel;
        private Label infoLabel;
    }
}