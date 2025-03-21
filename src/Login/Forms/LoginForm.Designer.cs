using Management.Components;

namespace Login.Forms;

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
        this.loginPictureBox = new PictureBox();
        this.userTextBox = new RoundedTextBox();
        this.passwordTextBox = new RoundedTextBox();
        this.loginButton = new Button();
        this.loginLabel = new Label();
        this.userDebugLabel = new Label();
        this.passwordDebugLabel = new Label();
        this.loginDebugLabel = new Label();
        this.registerButton = new Button();
        this.emailLabel = new Label();
        this.passwordLabel = new Label();
        ((System.ComponentModel.ISupportInitialize)this.loginPictureBox).BeginInit();
        this.SuspendLayout();
        // 
        // loginPictureBox
        // 
        this.loginPictureBox.Location = new Point(58, 50);
        this.loginPictureBox.Name = "loginPictureBox";
        this.loginPictureBox.Size = new Size(347, 307);
        this.loginPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
        this.loginPictureBox.TabIndex = 3;
        this.loginPictureBox.TabStop = false;
        // 
        // userTextBox
        // 
        this.userTextBox.BackColor = Color.Gainsboro;
        this.userTextBox.BorderStyle = BorderStyle.None;
        this.userTextBox.Font = new Font("Barlow", 11F);
        this.userTextBox.ForeColor = Color.DimGray;
        this.userTextBox.Location = new Point(121, 169);
        this.userTextBox.Multiline = true;
        this.userTextBox.Name = "userTextBox";
        this.userTextBox.Size = new Size(222, 23);
        this.userTextBox.TabIndex = 0;
        this.userTextBox.TextChanged += this.UserTextBox_TextChanged;
        // 
        // passwordTextBox
        // 
        this.passwordTextBox.BackColor = Color.Gainsboro;
        this.passwordTextBox.BorderStyle = BorderStyle.None;
        this.passwordTextBox.Font = new Font("Barlow", 11F);
        this.passwordTextBox.ForeColor = Color.DimGray;
        this.passwordTextBox.Location = new Point(121, 219);
        this.passwordTextBox.Multiline = true;
        this.passwordTextBox.Name = "passwordTextBox";
        this.passwordTextBox.Size = new Size(222, 23);
        this.passwordTextBox.TabIndex = 1;
        this.passwordTextBox.UseSystemPasswordChar = true;
        this.passwordTextBox.TextChanged += this.PasswordTextBox_TextChanged;
        // 
        // loginButton
        // 
        this.loginButton.BackColor = Color.MediumPurple;
        this.loginButton.BackgroundImageLayout = ImageLayout.None;
        this.loginButton.FlatStyle = FlatStyle.Popup;
        this.loginButton.Font = new Font("Barlow", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
        this.loginButton.ForeColor = SystemColors.InfoText;
        this.loginButton.Location = new Point(121, 265);
        this.loginButton.Name = "loginButton";
        this.loginButton.Size = new Size(222, 42);
        this.loginButton.TabIndex = 8;
        this.loginButton.Text = "Login";
        this.loginButton.UseVisualStyleBackColor = false;
        this.loginButton.Click += this.LoginButton_Click;
        // 
        // loginLabel
        // 
        this.loginLabel.AutoSize = true;
        this.loginLabel.Font = new Font("Barlow", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
        this.loginLabel.ForeColor = Color.DarkOrchid;
        this.loginLabel.Location = new Point(182, 99);
        this.loginLabel.Name = "loginLabel";
        this.loginLabel.Size = new Size(97, 39);
        this.loginLabel.TabIndex = 9;
        this.loginLabel.Text = "LOGIN";
        // 
        // userDebugLabel
        // 
        this.userDebugLabel.AutoSize = true;
        this.userDebugLabel.Font = new Font("Microsoft Sans Serif", 10F);
        this.userDebugLabel.Location = new Point(165, 196);
        this.userDebugLabel.Name = "userDebugLabel";
        this.userDebugLabel.Size = new Size(0, 17);
        this.userDebugLabel.TabIndex = 14;
        this.userDebugLabel.TextAlign = ContentAlignment.MiddleCenter;
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
        this.loginDebugLabel.Location = new Point(88, 330);
        this.loginDebugLabel.Name = "loginDebugLabel";
        this.loginDebugLabel.Size = new Size(0, 17);
        this.loginDebugLabel.TabIndex = 16;
        this.loginDebugLabel.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // registerButton
        // 
        this.registerButton.BackColor = SystemColors.Menu;
        this.registerButton.FlatStyle = FlatStyle.Flat;
        this.registerButton.Font = new Font("Barlow", 7F);
        this.registerButton.Location = new Point(121, 306);
        this.registerButton.Name = "registerButton";
        this.registerButton.Size = new Size(222, 21);
        this.registerButton.TabIndex = 17;
        this.registerButton.Text = "Registro";
        this.registerButton.UseVisualStyleBackColor = false;
        this.registerButton.Click += this.RegisterButton_Click;
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
        // LoginForm
        // 
        this.AutoScaleDimensions = new SizeF(7F, 15F);
        this.AutoScaleMode = AutoScaleMode.Font;
        this.BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
        this.ClientSize = new Size(457, 411);
        this.Controls.Add(this.passwordLabel);
        this.Controls.Add(this.emailLabel);
        this.Controls.Add(this.registerButton);
        this.Controls.Add(this.loginDebugLabel);
        this.Controls.Add(this.passwordDebugLabel);
        this.Controls.Add(this.userDebugLabel);
        this.Controls.Add(this.loginLabel);
        this.Controls.Add(this.loginButton);
        this.Controls.Add(this.passwordTextBox);
        this.Controls.Add(this.userTextBox);
        this.Controls.Add(this.loginPictureBox);
        this.Name = "LoginForm";
        this.StartPosition = FormStartPosition.CenterScreen;
        this.Text = "Login";
        ((System.ComponentModel.ISupportInitialize)this.loginPictureBox).EndInit();
        this.ResumeLayout(false);
        this.PerformLayout();
    }

    #endregion
    private PictureBox loginPictureBox;
    private RoundedTextBox userTextBox;
    private RoundedTextBox passwordTextBox;
    private Button loginButton;
    private Label loginLabel;
    private Label userDebugLabel;
    private Label passwordDebugLabel;
    private Label loginDebugLabel;
    private Button registerButton;
    private Label emailLabel;
    private Label passwordLabel;
}
