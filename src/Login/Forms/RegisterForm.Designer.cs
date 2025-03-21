using Management.Components;

namespace Login.Forms;

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
        this.registerPictureBox = new PictureBox();
        this.registerButton = new Button();
        this.returnButton = new Button();
        this.registerLabel = new Label();
        this.passwordDebugLabel = new Label();
        this.loginDebugLabel = new Label();
        this.emailLabel = new Label();
        this.passwordLabel = new Label();
        this.userTextBox = new RoundedTextBox();
        this.passwordTextBox = new RoundedTextBox();
        ((System.ComponentModel.ISupportInitialize)this.registerPictureBox).BeginInit();
        this.SuspendLayout();
        // 
        // registerPictureBox
        // 
        this.registerPictureBox.Location = new Point(58, 50);
        this.registerPictureBox.Name = "registerPictureBox";
        this.registerPictureBox.Size = new Size(347, 307);
        this.registerPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
        this.registerPictureBox.TabIndex = 3;
        this.registerPictureBox.TabStop = false;
        // 
        // registerButton
        // 
        this.registerButton.BackColor = Color.MediumPurple;
        this.registerButton.BackgroundImageLayout = ImageLayout.None;
        this.registerButton.FlatStyle = FlatStyle.Popup;
        this.registerButton.Font = new Font("Barlow", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
        this.registerButton.ForeColor = SystemColors.InfoText;
        this.registerButton.Location = new Point(121, 265);
        this.registerButton.Name = "registerButton";
        this.registerButton.Size = new Size(222, 42);
        this.registerButton.TabIndex = 8;
        this.registerButton.Text = "Registro";
        this.registerButton.UseVisualStyleBackColor = false;
        this.registerButton.Click += this.RegisterButton_Click;
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
        this.returnButton.Text = "Voltar para Login";
        this.returnButton.UseVisualStyleBackColor = false;
        this.returnButton.Click += this.ReturnButton_Click;
        // 
        // userTextBox
        // 
        userTextBox.BorderStyle = BorderStyle.None;
        userTextBox.Font = new Font("Trebuchet MS", 11F);
        userTextBox.ForeColor = Color.DimGray;
        userTextBox.Location = new Point(121, 169);
        userTextBox.Name = "userTextBox";
        userTextBox.Size = new Size(222, 18);
        userTextBox.TabIndex = 0;
        this.userTextBox.BackColor = Color.Gainsboro;
        this.userTextBox.Multiline = true;
        // 
        // passwordTextBox
        // 
        passwordTextBox.BorderStyle = BorderStyle.None;
        passwordTextBox.Font = new Font("Trebuchet MS", 11F);
        passwordTextBox.ForeColor = Color.DimGray;
        passwordTextBox.Location = new Point(121, 219);
        passwordTextBox.Name = "passwordTextBox";
        passwordTextBox.Size = new Size(222, 18);
        passwordTextBox.TabIndex = 1;
        passwordTextBox.UseSystemPasswordChar = true;
        this.passwordTextBox.BackColor = Color.Gainsboro;
        this.passwordTextBox.Multiline = true;
        // 
        // registerLabel
        // 
        this.registerLabel.AutoSize = true;
        this.registerLabel.Font = new Font("Barlow", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
        this.registerLabel.ForeColor = Color.DarkOrchid;
        this.registerLabel.Location = new Point(165, 95);
        this.registerLabel.Name = "registerLabel";
        this.registerLabel.Size = new Size(148, 39);
        this.registerLabel.TabIndex = 9;
        this.registerLabel.Text = "REGISTRO";
        // 
        // passwordDebugLabel
        // 
        this.passwordDebugLabel.AutoSize = true;
        this.passwordDebugLabel.Font = new Font("Microsoft Sans Serif", 10F);
        this.passwordDebugLabel.Location = new Point(165, 247);
        this.passwordDebugLabel.Name = "passwordDebugLabel";
        this.passwordDebugLabel.Size = new Size(0, 17);
        this.passwordDebugLabel.TabIndex = 15;
        this.passwordDebugLabel.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // loginDebugLabel
        // 
        this.loginDebugLabel.AutoSize = true;
        this.loginDebugLabel.Font = new Font("Microsoft Sans Serif", 10F);
        this.loginDebugLabel.Location = new Point(88, 310);
        this.loginDebugLabel.Name = "loginDebugLabel";
        this.loginDebugLabel.Size = new Size(0, 17);
        this.loginDebugLabel.TabIndex = 16;
        this.loginDebugLabel.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // emailLabel
        // 
        this.emailLabel.AutoSize = true;
        this.emailLabel.Font = new Font("Barlow", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
        this.emailLabel.ForeColor = SystemColors.ControlDarkDark;
        this.emailLabel.Location = new Point(121, 145);
        this.emailLabel.Name = "emailLabel";
        this.emailLabel.Size = new Size(45, 17);
        this.emailLabel.TabIndex = 18;
        this.emailLabel.Text = "E-mail";
        this.emailLabel.TextAlign = ContentAlignment.BottomCenter;
        // 
        // passwordLabel
        // 
        this.passwordLabel.AutoSize = true;
        this.passwordLabel.Font = new Font("Barlow", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
        this.passwordLabel.ForeColor = SystemColors.ControlDarkDark;
        this.passwordLabel.Location = new Point(121, 196);
        this.passwordLabel.Name = "passwordLabel";
        this.passwordLabel.Size = new Size(63, 17);
        this.passwordLabel.TabIndex = 19;
        this.passwordLabel.Text = "Password";
        this.passwordLabel.TextAlign = ContentAlignment.BottomCenter;
        // 
        // userTextBox
        // 
        this.userTextBox.BackColor = Color.Gainsboro;
        this.userTextBox.Multiline = true;
        this.userTextBox.BorderStyle = BorderStyle.None;
        this.userTextBox.Font = new Font("Barlow", 11F);
        this.userTextBox.ForeColor = Color.DimGray;
        this.userTextBox.Location = new Point(121, 169);
        this.userTextBox.Name = "userTextBox";
        this.userTextBox.Size = new Size(222, 18);
        this.userTextBox.TabIndex = 0;
        // 
        // passwordTextBox
        // 
        this.passwordTextBox.BackColor = Color.Gainsboro;
        this.passwordTextBox.Multiline = true;
        this.passwordTextBox.BorderStyle = BorderStyle.None;
        this.passwordTextBox.Font = new Font("Barlow", 11F);
        this.passwordTextBox.ForeColor = Color.DimGray;
        this.passwordTextBox.Location = new Point(121, 219);
        this.passwordTextBox.Name = "passwordTextBox";
        this.passwordTextBox.Size = new Size(222, 18);
        this.passwordTextBox.TabIndex = 1;
        this.passwordTextBox.UseSystemPasswordChar = true;
        // 
        // RegisterForm
        // 
        this.AutoScaleDimensions = new SizeF(7F, 15F);
        this.AutoScaleMode = AutoScaleMode.Font;
        this.BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
        this.ClientSize = new Size(457, 411);
        this.Controls.Add(this.loginDebugLabel);
        this.Controls.Add(this.passwordDebugLabel);
        this.Controls.Add(this.registerLabel);
        this.Controls.Add(this.registerButton);
        this.Controls.Add(this.returnButton);
        this.Controls.Add(this.emailLabel);
        this.Controls.Add(this.passwordLabel);
        this.Controls.Add(this.registerPictureBox);
        this.Controls.Add(this.userTextBox);
        this.Controls.Add(this.passwordTextBox);
        this.Name = "RegisterForm";
        this.StartPosition = FormStartPosition.CenterScreen;
        this.Text = "Registro";
        ((System.ComponentModel.ISupportInitialize)this.registerPictureBox).EndInit();
        this.ResumeLayout(false);
        this.PerformLayout();
    }

    #endregion
    private PictureBox loginPictureBox;
    private RoundedTextBox userTextBox;
    private RoundedTextBox passwordTextBox;
    private Button registerButton;
    private Button returnButton;
    private Label loginLabel;
    private Label passwordDebugLabel;
    private Label loginDebugLabel;
    private PictureBox registerPictureBox;
    private Label registerLabel;
    private Label emailLabel;
    private Label passwordLabel;
}
