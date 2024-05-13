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
            ReloadListItems();
        }

        private void ReloadListItems()
        {
            MySqlConnection? connection = Connection.MySqlConnection;

            usersCheckedListBox.Items.Clear();

            if (connection != null)
            {
                usersCheckedListBox.Items.AddRange(SqlQuery.GetEmails(connection).ToArray());
            }
            else
            {
                usersCheckedListBox.Items.Add("Oops! Conexão inválida.");
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }

        private void userListBox_DoubleClick(object sender, EventArgs e)
        {
            object? item = usersCheckedListBox.SelectedItem;

            if (item != null)
            {
                usersCheckedListBox.Items.Remove(item);
            }
        }

        private void usersCheckedListBox_DoubleClick(object sender, EventArgs e)
        {
            object? item = usersCheckedListBox.SelectedItem;

            if (item != null)
            {
                new ChangePassForm((string)item).Show();
                this.Hide();
            }
        }

        private void removeEmailsButton_Click(object sender, EventArgs e)
        {
            MySqlConnection? connection = Connection.MySqlConnection;

            if (connection != null)
            {
                foreach (object item in usersCheckedListBox.CheckedItems)
                {
                    string email = (string)item;

                    if (!string.IsNullOrEmpty(email))
                    {
                        SqlQuery.RemoveLoginByEmail(connection, email);
                    }
                }

                ReloadListItems();
            }
        }
    }
}
