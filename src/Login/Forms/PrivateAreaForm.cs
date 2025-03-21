using Login.Database;
using Login.Database.Query;
using Login.Login.Templates;
using MySql.Data.MySqlClient;

namespace Login.Forms;

public partial class PrivateAreaForm : TemplateForm
{
    public PrivateAreaForm()
    {
        InitializeComponent();
        ReloadListItems();
    }

    private void ReloadListItems()
    {
        MySqlConnection? connection = ConnectionDB.MySqlConnection;

        usersCheckedListBox.Items.Clear();

        if (connection != null)
        {
            usersCheckedListBox.Items.AddRange(QueryDB.GetEmails(connection).ToArray());
        }
        else
        {
            usersCheckedListBox.Items.Add("Oops! Conexão inválida.");
        }
    }

    private void ExitButton_Click(object sender, EventArgs e)
    {
        Environment.Exit(1);
    }

    private void UserListBox_DoubleClick(object sender, EventArgs e)
    {
        object? item = usersCheckedListBox.SelectedItem;

        if (item != null)
        {
            usersCheckedListBox.Items.Remove(item);
        }
    }

    private void UsersCheckedListBox_DoubleClick(object sender, EventArgs e)
    {
        object? item = usersCheckedListBox.SelectedItem;

        if (item != null)
        {
            new ChangePassForm((string)item).Show();
            this.Hide();
        }
    }

    private void RemoveEmailsButton_Click(object sender, EventArgs e)
    {
        MySqlConnection? connection = ConnectionDB.MySqlConnection;

        if (connection != null)
        {
            foreach (object item in usersCheckedListBox.CheckedItems)
            {
                string email = (string)item;

                if (!string.IsNullOrEmpty(email))
                {
                    QueryDB.RemoveLoginByEmail(connection, email);
                }
            }

            ReloadListItems();
        }
    }
}
