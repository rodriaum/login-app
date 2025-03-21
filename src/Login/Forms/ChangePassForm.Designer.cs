using Management.Components;

namespace Login.Forms;

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
        this.confirmEmailPictureBox = new PictureBox();
        this.verifyButton = new Button();
        this.confirmEmailLabel = new Label();
        this.returnButton = new Button();
        this.emailLabel = new Label();
        this.userPasswordLabel = new Label();
        this.passwordTextBox = new RoundedTextBox();
        ((System.ComponentModel.ISupportInitialize)this.confirmEmailPictureBox).BeginInit();
        this.SuspendLayout();
        // 
        // confirmEmailPictureBox
        // 
        this.confirmEmailPictureBox.Location = new Point(58, 50);
        this.confirmEmailPictureBox.Name = "confirmEmailPictureBox";
        this.confirmEmailPictureBox.Size = new Size(347, 307);
        this.confirmEmailPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
        this.confirmEmailPictureBox.TabIndex = 3;
        this.confirmEmailPictureBox.TabStop = false;
        this.confirmEmailPictureBox.Click += this.confirmEmailPictureBox_Click;
        this.confirmEmailPictureBox.BackColor = Color.White;
        // 
        // verifyButton
        // 
        this.verifyButton.BackColor = Color.MediumPurple;
        this.verifyButton.BackgroundImageLayout = ImageLayout.None;
        this.verifyButton.FlatStyle = FlatStyle.Popup;
        this.verifyButton.Font = new Font("Barlow", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
        this.verifyButton.ForeColor = SystemColors.MenuText;
        this.verifyButton.Location = new Point(121, 265);
        this.verifyButton.Name = "verifyButton";
        this.verifyButton.Size = new Size(222, 42);
        this.verifyButton.TabIndex = 8;
        this.verifyButton.Text = "Alterar";
        this.verifyButton.UseVisualStyleBackColor = false;
        this.verifyButton.Click += this.VerifyButton_Click;
        // 
        // confirmEmailLabel
        // 
        this.confirmEmailLabel.AutoSize = true;
        this.confirmEmailLabel.Font = new Font("Barlow", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
        this.confirmEmailLabel.ForeColor = Color.DarkOrchid;
        this.confirmEmailLabel.Location = new Point(88, 102);
        this.confirmEmailLabel.Name = "confirmEmailLabel";
        this.confirmEmailLabel.Size = new Size(290, 39);
        this.confirmEmailLabel.TabIndex = 9;
        this.confirmEmailLabel.Text = "ALTERAR PASSWORD";
        // 
        // returnButton
        // 
        this.returnButton.BackColor = SystemColors.Menu;
        this.returnButton.FlatStyle = FlatStyle.Flat;
        this.returnButton.Font = new Font("Barlow", 7F);
        this.returnButton.Location = new Point(121, 306);
        this.returnButton.Name = "returnButton";
        this.returnButton.Size = new Size(222, 21);
        this.returnButton.TabIndex = 17;
        this.returnButton.Text = "Voltar para Área Privada";
        this.returnButton.UseVisualStyleBackColor = false;
        this.returnButton.Click += this.ReturnButton_Click;
        // 
        // passwordTextBox
        // 
        passwordTextBox.BackColor = Color.Gainsboro;
        passwordTextBox.Multiline = true;
        passwordTextBox.BorderStyle = BorderStyle.None;
        passwordTextBox.Font = new Font("Barlow", 11F);
        passwordTextBox.ForeColor = Color.DimGray;
        passwordTextBox.Location = new Point(121, 169);
        passwordTextBox.MaxLength = 6;
        passwordTextBox.Name = "passwordTextBox";
        passwordTextBox.Size = new Size(222, 18);
        passwordTextBox.TabIndex = 0;
        // 
        // emailLabel
        // 
        this.emailLabel.AutoSize = true;
        this.emailLabel.Font = new Font("Barlow", 8F, FontStyle.Italic);
        this.emailLabel.ForeColor = Color.MediumPurple;
        this.emailLabel.Location = new Point(180, 126);
        this.emailLabel.Name = "emailLabel";
        this.emailLabel.Size = new Size(0, 15);
        this.emailLabel.TabIndex = 18;
        this.emailLabel.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // userPasswordLabel
        // 
        this.userPasswordLabel.AutoSize = true;
        this.userPasswordLabel.Font = new Font("Barlow", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
        this.userPasswordLabel.ForeColor = SystemColors.ControlDarkDark;
        this.userPasswordLabel.Location = new Point(121, 145);
        this.userPasswordLabel.Name = "userPasswordLabel";
        this.userPasswordLabel.Size = new Size(63, 17);
        this.userPasswordLabel.TabIndex = 18;
        this.userPasswordLabel.Text = "Password";
        this.userPasswordLabel.TextAlign = ContentAlignment.BottomCenter;
        // 
        // ChangePassForm
        // 
        this.AutoScaleDimensions = new SizeF(7F, 15F);
        this.AutoScaleMode = AutoScaleMode.Font;
        this.BackColor = Color.FromArgb(20, 21, 40); this.ClientSize = new Size(457, 411);
        this.Controls.Add(this.emailLabel);
        this.Controls.Add(this.returnButton);
        this.Controls.Add(this.confirmEmailLabel);
        this.Controls.Add(this.verifyButton);
        this.Controls.Add(this.userPasswordLabel);
        this.Controls.Add(this.confirmEmailPictureBox);
        this.Controls.Add(passwordTextBox);
        this.Name = "ChangePassForm";
        this.StartPosition = FormStartPosition.CenterScreen;
        this.Text = "Confirmar E-mail";
        this.ResumeLayout(false);
        this.PerformLayout();
    }

    #endregion
    private PictureBox confirmEmailPictureBox;
    private RoundedTextBox passwordTextBox;
    private Button verifyButton;
    private Label confirmEmailLabel;
    private Button returnButton;
    private Label emailLabel;
    private Label userPasswordLabel;
}