using Login.backend;
using Login.backend.query;
using Login.util;
using MySql.Data.MySqlClient;

namespace Login
{
    public partial class ChangePassForm : Form
    {
        static string? email { get; set; }

        public ChangePassForm(string emailAdress)
        {
            InitializeComponent();

            email = emailAdress;
            SetDefaultLabel();
        }

        private void SetDefaultLabel()
        {
            emailLabel.Text = email;
        }

        private void returnButton_Click(object sender, EventArgs e)
        {
            new PrivateAreaForm().Show();
            this.Hide();
        }

        private void changeButton_Click(object sender, EventArgs e)
        {

        }

        private async void verifyButton_Click(object sender, EventArgs e)
        {
            MySqlConnection? connection = Connection.MySqlConnection;

            string password = passwordTextBox.Text;

            if (connection != null && !string.IsNullOrEmpty(email) && !string.IsNullOrEmpty(password))
            {
                SqlQuery.ChangePassword(connection, email, Util.HashPassword(password));

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
    }
}
