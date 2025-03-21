using Login.Database;
using Login.Database.Query;
using Login.Helper;
using Login.Login.Templates;
using Login.Service;
using MySql.Data.MySqlClient;
using System.Net.Mail;

namespace Login.Forms;

public partial class RegisterForm : TemplateForm
{
    public RegisterForm()
    {
        InitializeComponent();
    }

    private void RegisterButton_Click(object sender, EventArgs e)
    {
        MySqlConnection? connection = ConnectionDB.MySqlConnection;
        Button button = registerButton;

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
                    AppHelper.DebugMessageBox("Parece que esse email já está associado a outro usuário.");
                }
                else
                {
                    new ConfirmEmailForm().Show();
                    this.Hide();

                    // Pode adicionar uma verificação caso exista o mesmo código no banco de dados.
                    string code = new Random().Next(100000, 999999).ToString();

                    QueryDB.CreateLogin(connection, email, BCrypt.Net.BCrypt.HashPassword(password), code);

                    // Coloquem as credenciais do seu e-mail.

                    

                    SmtpService smtpService = new SmtpService(
                        Environment.GetEnvironmentVariable("SMTP_USERNAME"), 
                        Environment.GetEnvironmentVariable("SMTP_PASSWORD")
                    );

                    smtpService.DispatchConfirmEmail("", email, code);
                }
            }
        }
        else
        {
            AppHelper.OutgoingError("Botão ou conexão com o banco de dados nulo.");
        }
    }

    private void ReturnButton_Click(object sender, EventArgs e)
    {
        new LoginForm().Show();
        this.Hide();
    }
}
