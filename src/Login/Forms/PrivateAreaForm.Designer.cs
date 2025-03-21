using Login.Properties;

namespace Login.Forms;

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
        this.privateAreaPictureBox = new PictureBox();
        this.usersCheckedListBox = new CheckedListBox();
        this.removeEmailsButton = new Button();
        this.exitButton = new Button();
        this.userLabel = new Label();
        this.infoLabel = new Label();
        ((System.ComponentModel.ISupportInitialize)this.privateAreaPictureBox).BeginInit();
        this.SuspendLayout();
        // 
        // privateAreaPictureBox
        // 
        this.privateAreaPictureBox.Location = new Point(58, 50);
        this.privateAreaPictureBox.Name = "privateAreaPictureBox";
        this.privateAreaPictureBox.Size = new Size(347, 307);
        this.privateAreaPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
        this.privateAreaPictureBox.TabIndex = 2;
        this.privateAreaPictureBox.TabStop = false;
        // 
        // usersCheckedListBox
        // 
        this.usersCheckedListBox.FormattingEnabled = true;
        this.usersCheckedListBox.Location = new Point(58, 110);
        this.usersCheckedListBox.Name = "usersCheckedListBox";
        this.usersCheckedListBox.Size = new Size(347, 202);
        this.usersCheckedListBox.TabIndex = 3;
        this.usersCheckedListBox.DoubleClick += this.UsersCheckedListBox_DoubleClick;
        // 
        // removeEmailsButton
        // 
        this.removeEmailsButton.Location = new Point(58, 315);
        this.removeEmailsButton.Name = "removeEmailsButton";
        this.removeEmailsButton.Size = new Size(175, 42);
        this.removeEmailsButton.TabIndex = 4;
        this.removeEmailsButton.Text = "Remover E-mails Selecionados";
        this.removeEmailsButton.UseVisualStyleBackColor = true;
        this.removeEmailsButton.Click += this.RemoveEmailsButton_Click;
        // 
        // exitButton
        // 
        this.exitButton.Location = new Point(230, 315);
        this.exitButton.Name = "exitButton";
        this.exitButton.Size = new Size(175, 42);
        this.exitButton.TabIndex = 5;
        this.exitButton.Text = "Sair";
        this.exitButton.UseVisualStyleBackColor = true;
        this.exitButton.Click += this.ExitButton_Click;
        // 
        // userLabel
        // 
        this.userLabel.AutoSize = true;
        this.userLabel.Font = new Font("Barlow", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
        this.userLabel.ForeColor = Color.DarkOrchid;
        this.userLabel.Location = new Point(162, 53);
        this.userLabel.Name = "userLabel";
        this.userLabel.Size = new Size(149, 39);
        this.userLabel.TabIndex = 10;
        this.userLabel.Text = "USUÁRIOS";
        // 
        // infoLabel
        // 
        this.infoLabel.AutoSize = true;
        this.infoLabel.Font = new Font("Barlow", 8F, FontStyle.Italic);
        this.infoLabel.ForeColor = Color.MediumPurple;
        this.infoLabel.Location = new Point(129, 92);
        this.infoLabel.Name = "infoLabel";
        this.infoLabel.Size = new Size(204, 15);
        this.infoLabel.TabIndex = 11;
        this.infoLabel.Text = "Clique 2x para alterar password do e-mail.";
        // 
        // PrivateAreaForm
        // 
        this.AutoScaleDimensions = new SizeF(7F, 15F);
        this.AutoScaleMode = AutoScaleMode.Font;
        this.BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
        this.ClientSize = new Size(457, 411);
        this.Controls.Add(this.infoLabel);
        this.Controls.Add(this.userLabel);
        this.Controls.Add(this.removeEmailsButton);
        this.Controls.Add(this.exitButton);
        this.Controls.Add(this.usersCheckedListBox);
        this.Controls.Add(this.privateAreaPictureBox);
        this.Name = "PrivateAreaForm";
        this.StartPosition = FormStartPosition.CenterScreen;
        this.Text = "PrivateAreaForm";
        ((System.ComponentModel.ISupportInitialize)this.privateAreaPictureBox).EndInit();
        this.ResumeLayout(false);
        this.PerformLayout();
    }

    #endregion
    private PictureBox privateAreaPictureBox;
    private CheckedListBox usersCheckedListBox;
    private Button removeEmailsButton;
    private Button exitButton;
    private Label userLabel;
    private Label infoLabel;
}