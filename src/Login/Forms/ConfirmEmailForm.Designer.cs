using Management.Components;

namespace Login.Forms;

partial class ConfirmEmailForm
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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfirmEmailForm));
        this.confirmEmailPictureBox = new PictureBox();
        this.verifyButton = new Button();
        this.confirmEmailLabel = new Label();
        this.confirmEmailDebugLabel = new Label();
        this.returnButton = new Button();
        this.userCodeLabel = new Label();
        this.codeTextBox = new RoundedTextBox();
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
        // 
        // verifyButton
        // 
        this.verifyButton.BackColor = Color.MediumPurple;
        this.verifyButton.BackgroundImageLayout = ImageLayout.None;
        this.verifyButton.FlatStyle = FlatStyle.Popup;
        this.verifyButton.Font = new Font("Barlow", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
        this.verifyButton.ForeColor = SystemColors.InfoText;
        this.verifyButton.Location = new Point(121, 265);
        this.verifyButton.Name = "verifyButton";
        this.verifyButton.Size = new Size(222, 42);
        this.verifyButton.TabIndex = 8;
        this.verifyButton.Text = "Verificar";
        this.verifyButton.UseVisualStyleBackColor = false;
        this.verifyButton.Click += this.VerifyButton_Click;
        // 
        // codeTextBox
        // 
        codeTextBox.BackColor = SystemColors.Menu;
        codeTextBox.BorderStyle = BorderStyle.None;
        codeTextBox.Font = new Font("Barlow", 11F);
        codeTextBox.ForeColor = Color.DimGray;
        codeTextBox.Location = new Point(121, 169);
        codeTextBox.MaxLength = 6;
        codeTextBox.Name = "codeTextBox";
        codeTextBox.Size = new Size(222, 18);
        codeTextBox.TabIndex = 0;
        // 
        // confirmEmailLabel
        // 
        this.confirmEmailLabel.AutoSize = true;
        this.confirmEmailLabel.Font = new Font("Barlow", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
        this.confirmEmailLabel.ForeColor = Color.DarkOrchid;
        this.confirmEmailLabel.Location = new Point(106, 95);
        this.confirmEmailLabel.Name = "confirmEmailLabel";
        this.confirmEmailLabel.Size = new Size(257, 39);
        this.confirmEmailLabel.TabIndex = 9;
        this.confirmEmailLabel.Text = "VERIFICAR E-MAIL";
        // 
        // confirmEmailDebugLabel
        // 
        this.confirmEmailDebugLabel.AutoSize = true;
        this.confirmEmailDebugLabel.Font = new Font("Barlow", 10F);
        this.confirmEmailDebugLabel.Location = new Point(88, 330);
        this.confirmEmailDebugLabel.Name = "confirmEmailDebugLabel";
        this.confirmEmailDebugLabel.Size = new Size(0, 17);
        this.confirmEmailDebugLabel.TabIndex = 16;
        this.confirmEmailDebugLabel.TextAlign = ContentAlignment.MiddleCenter;
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
        this.returnButton.Click += this.RegisterButton_Click;
        // 
        // userCodeLabel
        // 
        this.userCodeLabel.AutoSize = true;
        this.userCodeLabel.Font = new Font("Barlow", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
        this.userCodeLabel.ForeColor = SystemColors.ControlDarkDark;
        this.userCodeLabel.Location = new Point(121, 145);
        this.userCodeLabel.Name = "userCodeLabel";
        this.userCodeLabel.Size = new Size(108, 17);
        this.userCodeLabel.TabIndex = 18;
        this.userCodeLabel.Text = "Código de Acesso";
        this.userCodeLabel.TextAlign = ContentAlignment.BottomCenter;
        // 
        // ConfirmEmailForm
        // 
        this.AutoScaleDimensions = new SizeF(7F, 15F);
        this.AutoScaleMode = AutoScaleMode.Font;
        this.BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
        this.ClientSize = new Size(457, 411);
        this.Controls.Add(this.returnButton);
        this.Controls.Add(this.confirmEmailDebugLabel);
        this.Controls.Add(this.userCodeLabel);
        this.Controls.Add(this.confirmEmailLabel);
        this.Controls.Add(this.verifyButton);
        this.Controls.Add(this.confirmEmailPictureBox);
        this.Controls.Add(codeTextBox);
        this.Name = "ConfirmEmailForm";
        this.StartPosition = FormStartPosition.CenterScreen;
        this.Text = "Confirmar E-mail";
        ((System.ComponentModel.ISupportInitialize)this.confirmEmailPictureBox).EndInit();
        this.ResumeLayout(false);
        this.PerformLayout();
    }

    #endregion
    private PictureBox confirmEmailPictureBox;
    private RoundedTextBox codeTextBox;
    private Button verifyButton;
    private Label confirmEmailLabel;
    private Label confirmEmailDebugLabel;
    private Button returnButton;
    private Label userCodeLabel;
}