using Login.backend;
using Login.backend.query;
using Login.util;
using MySql.Data.MySqlClient;

namespace Login
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            MySqlConnection? connection = Connection.MySqlConnection;
            Button button = registerButton;

            if (button != null && connection != null)
            {
                string email = userTextBox.Text;
                string password = passwordTextBox.Text;

                if (string.IsNullOrEmpty(email) || !email.Contains("@"))
                {
                    Util.DebugLabel(userDebugLabel, "Insira um e-mail válido.");
                }

                if (string.IsNullOrEmpty(password))
                {
                    Util.DebugLabel(passwordDebugLabel, "Insira uma password válida.");
                }

                if (!string.IsNullOrEmpty(email) && !string.IsNullOrEmpty(password) && email.Contains("@"))
                {
                    if (SqlQuery.HasLogin(connection, email))
                    {
                        Util.DebugLabel(loginDebugLabel, "Parece que esse email já está associado a outro usuário.");
                    }
                    else
                    {
                        new ConfirmEmailForm().Show();
                        this.Hide();

                        string code = new Random().Next(100000, 999999).ToString();

                        SqlQuery.CreateLogin(connection, email, password, code);

                        // Para o projeto funcionar com o confirmador de e-mail, você precisa adicionar as credenciais.
                        // SmtpHelper.SendConfirmationEmail(
                        //    SmtpHelper.Connection("", ""),
                        //    "", email, code);
                    }
                }
            }
            else
            {
                Util.OutgoingError("Botão ou conexão com o banco de dados nulo.");
            }
        }

        private void returnButton_Click(object sender, EventArgs e)
        {
            new LoginForm().Show();
            this.Hide();
        }
    }
}
