using Login.backend;
using Login.backend.query;
using Login.util;
using MySql.Data.MySqlClient;

namespace Login
{
    public partial class Form1 : Form
    {

        static MySqlConnection? connection;

        public Form1()
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

                    //Util.OutgoingError(SqlQuery.VerifyLogin(connection, userTextBox.Text, passwordTextBox.Text).ToString());

                    if (SqlQuery.VerifyLogin(connection, userTextBox.Text, passwordTextBox.Text))
                    {
                        Util.DebugLabel(loginDebugLabel, "Login certo");
                    }
                    else
                    {
                        Util.DebugLabel(loginDebugLabel, "Os parâmetros de login estão incorreto ou não existe registro.");
                    }
                }
            }
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
