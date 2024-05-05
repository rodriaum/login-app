using Login.backend;
using Login.backend.query;
using Login.util;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Login
{
    public partial class LoginForm : Form
    {

        public LoginForm()
        {
            InitializeComponent();
            Connection.Init();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            Button button = loginButton;
            if (button != null && Connection.MySqlConnection != null)
            {
                string email = userTextBox.Text;
                string password = passwordTextBox.Text;

                if (string.IsNullOrEmpty(email) && !email.Contains("@"))
                {
                    Util.DebugLabel(userDebugLabel, "Insira um e-mail válido.");
                }

                if (string.IsNullOrEmpty(password))
                {
                    Util.DebugLabel(passwordDebugLabel, "Insira uma password válida.");
                }

                if (!string.IsNullOrEmpty(email) && !string.IsNullOrEmpty(password))
                {
                    if (SqlQuery.VerifyLogin(Connection.MySqlConnection, email, password))
                    {
                        // Caso use o projeto, use sua criatividade aqui!
                        Util.DebugLabel(loginDebugLabel, "Login efetuado com sucesso.");
                    }
                    else
                    {
                        Util.DebugLabel(loginDebugLabel, "Os parâmetros de login estão incorreto ou não existe registro.");
                    }
                }
            } 
            else
            {
                Util.OutgoingError("Botão ou conexão com o banco de dados nulo.");
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
