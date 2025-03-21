using Login.Database;
using Login.Database.Query;
using Login.Helper;
using Login.Login.Templates;
using MySql.Data.MySqlClient;

namespace Login.Forms;

public partial class LoginForm : TemplateForm
{

    public LoginForm(string? email = null, string? password = null)
    {
        InitializeComponent();
        ConnectionDB.Init();

        if (!string.IsNullOrWhiteSpace(email))
        {
            userTextBox.Text = email;
        }

        if (!string.IsNullOrWhiteSpace(password)) 
        { 
            passwordTextBox.Text = password;
        }
    }

    private async void LoginButton_Click(object sender, EventArgs e)
    {
        MySqlConnection? connection = ConnectionDB.MySqlConnection;
        Button button = loginButton;

        if (button != null && connection != null)
        {
            string email = userTextBox.Text;
            string password = passwordTextBox.Text;

            if (string.IsNullOrEmpty(email) || !email.Contains("@"))
            {
                AppHelper.DebugMessageBox("Insira um e-mail válido.");
            }

            if (string.IsNullOrEmpty(password))
            {
                AppHelper.DebugMessageBox("Insira uma password válida.");
            }

            if (!string.IsNullOrEmpty(email) && !string.IsNullOrEmpty(password) && email.Contains("@"))
            {

                if (QueryDB.HasLogin(connection, email))
                {
                    if (QueryDB.VerifyLogin(connection, email, EncryptionHelper.SHA256(password)))
                    {
                        if (QueryDB.HasConfirmedEmail(connection, email))
                        {
                            new PrivateAreaForm().Show();
                            this.Hide();
                        }
                        else
                        {
                            AppHelper.DebugMessageBox("Você precisa verificar o e-mail antes de fazer login.");

                            await Task.Delay(1000);

                            new ConfirmEmailForm().Show();
                            this.Hide();
                        }
                    }
                    else
                    {
                        AppHelper.DebugMessageBox("Os parâmetros de login estão incorreto.");
                    }
                }
                else
                {
                    AppHelper.DebugMessageBox("Não existe nenhum login com essas credenciais.");
                }
            }
        }
        else
        {
            AppHelper.OutgoingError("Botão ou conexão com o banco de dados nulo.");
        }
    }

    private void RegisterButton_Click(object sender, EventArgs e)
    {
        RegisterForm form = new RegisterForm();

        form.Show();
        this.Hide();
    }

    private void UserTextBox_TextChanged(object sender, EventArgs e)
    {
        userTextBox.Focus();
    }

    private void PasswordTextBox_TextChanged(object sender, EventArgs e)
    {
        passwordTextBox.Focus();
    }
}
