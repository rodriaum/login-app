using Login.backend.query;
using Login.backend;
using Login.util;
using System.Text.RegularExpressions;
using MySql.Data.MySqlClient;

namespace Login
{
    public partial class ConfirmEmailForm : Form
    {
        public ConfirmEmailForm()
        {
            InitializeComponent();
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            new LoginForm("", "").Show();
            this.Hide();
        }

        private async void verifyButton_Click(object sender, EventArgs e)
        {
            MySqlConnection? connection = Connection.MySqlConnection;
            Button button = verifyButton;

            if (button != null && connection != null)
            {
                string code = codeTextBox.Text;
                string email = SqlQuery.GetEmailByConfirmCode(connection, code);

                // Regex: Verifica se é dígito.
                if (string.IsNullOrEmpty(code) && !Regex.IsMatch(code, @"^[0-9]+$"))
                {
                    Util.DebugLabel(codeDebugLabel, "Insira um código válido.");
                }
                else
                {
                    if (SqlQuery.VerifyConfirmationEmail(connection, email, code) && SqlQuery.ConfirmEmail(connection, email))
                    {
                        Util.DebugLabel(confirmEmailDebugLabel, "E-mail confirmado com sucesso.");

                        await Task.Delay(1000);

                        new LoginForm(email, "").Show();
                        this.Hide();
                    }
                    else
                    {
                        Util.DebugLabel(confirmEmailDebugLabel, "Não foi possível confirmar o seu registro.");
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
