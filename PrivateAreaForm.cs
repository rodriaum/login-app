using Login.backend;
using Login.backend.query;
using MySql.Data.MySqlClient;

namespace Login
{
    public partial class PrivateAreaForm : Form
    {
        public PrivateAreaForm()
        {
            InitializeComponent();

            MySqlConnection? connection = Connection.MySqlConnection;

            if (connection != null)
            {
                userListBox.Items.AddRange(SqlQuery.GetEmails(connection).ToArray());
            }
            else
            {
                userListBox.Items.Add("Oops! Conexão inválida.");
            }
        }

        private async void saveButton_Click(object sender, EventArgs e)
        {
            infoLabel.Text = "Alterações guardadas com sucesso! A atualizar.";
            await Task.Delay(1500);
            infoLabel.Text = "Clique 2x para remover, 1x para alterar senha.";
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }

        private void userListBox_DoubleClick(object sender, EventArgs e)
        {
            object? item = userListBox.SelectedItem;

            if (item != null)
            {
                userListBox.Items.Remove(item);
            }
        }

        private void userListBox_Click(object sender, EventArgs e)
        {
            object? item = userListBox.SelectedItem;

            if (item != null)
            {
                new ChangePassForm((string)item).Show();
                this.Hide();
            }
        }
    }
}
