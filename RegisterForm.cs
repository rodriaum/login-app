using Login.backend;
using Login.backend.query;
using Login.util;

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
            Button button = registerButton;

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
                    if (SqlQuery.HasLogin(Connection.MySqlConnection, email))
                    {
                        Util.DebugLabel(loginDebugLabel, "Parece que esse email já está associado a outro usuário.");
                    }
                    else
                    {
                        // Enviar para confirmar via email
                        // SqlQuery.CreateLogin(Connection.MySqlConnection, email, password);
                    }
                }
            } 
            else
            {
                Util.OutgoingError("Botão ou conexão com o banco de dados nulo.");
            }
        }
    }
}
