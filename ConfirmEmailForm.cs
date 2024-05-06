using Login.backend.query;
using Login.backend;
using Login.util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using System.Text.RegularExpressions;
using MySql.Data.MySqlClient;
using Login.smtp;

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
            new LoginForm().Show();
            this.Hide();
        }

        private async void verifyButton_Click(object sender, EventArgs e)
        {
            MySqlConnection? connection = Connection.MySqlConnection;
            Button button = verifyButton;

            if (button != null && connection != null)
            {
                // Email

                string code = codeTextBox.Text;
                string email = SqlQuery.GetEmailByConfirmCode(connection, code);

                // Regex: Verifica se é dígito.
                if (string.IsNullOrEmpty(code) && !Regex.IsMatch(code, @"^[0-9]+$"))
                {
                    Util.DebugLabel(codeDebugLabel, "Insira um código válido.");
                }
                else
                {
                    if (SqlQuery.HasConfirmedEmail(connection, email))
                    {
                        Util.DebugLabel(confirmEmailDebugLabel, "Parece que esse email já está associado a outro usuário.");
                    }
                    else
                    {
                        if (SqlQuery.VerifyConfirmationEmail(connection, email, code))
                        {
                            Util.DebugLabel(confirmEmailDebugLabel, "E-mail confirmado com sucesso.");

                            await Task.Delay(1000);

                            new LoginForm().Show();
                            this.Hide();
                        }
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
