using Login.Database;
using Login.Database.Query;
using Login.Login.Templates;
using MySql.Data.MySqlClient;

namespace Login.Forms;

public partial class ChangePassForm : TemplateForm
{
    static string? _email { get; set; }

    public ChangePassForm(string emailAdress)
    {
        InitializeComponent();

        _email = emailAdress;
        SetDefaultLabel();
    }

    private void SetDefaultLabel()
    {
        emailLabel.Text = _email;
    }

    private void ReturnButton_Click(object sender, EventArgs e)
    {
        new PrivateAreaForm().Show();
        this.Hide();
    }

    private void ChangeButton_Click(object sender, EventArgs e)
    {

    }

    private async void VerifyButton_Click(object sender, EventArgs e)
    {
        MySqlConnection? connection = ConnectionDB.MySqlConnection;

        string password = passwordTextBox.Text;

        if (connection != null && !string.IsNullOrEmpty(_email) && !string.IsNullOrEmpty(password))
        {
            QueryDB.ChangePassword(connection, _email, BCrypt.Net.BCrypt.HashPassword(password));

            emailLabel.Text = "E-mail alterado com sucesso.";
            await Task.Delay(1000);

            new PrivateAreaForm().Show();
            this.Hide();
        }
        else
        {
            emailLabel.Text = "E-mail escolhido ou conexão inválido(a)";
            await Task.Delay(3000);
            SetDefaultLabel();
        }
    }

    private void confirmEmailPictureBox_Click(object sender, EventArgs e)
    {

    }
}