using Login.backend;
using Login.backend.query;
using Login.util;
using MySql.Data.MySqlClient;

namespace Login
{
    public partial class LoginForm : Form
    {

        static MySqlConnection? connection;

        public LoginForm()
        {
            InitializeComponent();
            connection = Connection.Init();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            Button button = loginButton;

            if (button != null && connection != null)
            {
                if (string.IsNullOrEmpty(userTextBox.Text))
                {
                    Util.DebugLabel(userDebugLabel, "Insira um e-mail válido.");
                }

                if (string.IsNullOrEmpty(passwordTextBox.Text))
                {
                    Util.DebugLabel(passwordDebugLabel, "Insira uma password válida.");
                }

                if (!string.IsNullOrEmpty(userTextBox.Text) && !string.IsNullOrEmpty(passwordTextBox.Text))
                {
                    if (SqlQuery.VerifyLogin(connection, userTextBox.Text, passwordTextBox.Text))
                    {
                        // Caso use o projeto, use sua criatividade aqui!
                        Util.DebugLabel(loginDebugLabel, "Login efetuado com sucesso");
                    }
                    else
                    {
                        Util.DebugLabel(loginDebugLabel, "Os parâmetros de login estão incorreto ou não existe registro.");
                    }
                }
            }
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            RegisterForm form = new RegisterForm();

            form.Show();
            this.Hide();
        }

        private void userTextBox_TextChanged(object sender, EventArgs e)
        {
            userTextBox.Focus();
        }

        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {
            passwordTextBox.Focus();
        }
    }
}
