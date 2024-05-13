using Login.backend;
using Login.backend.query;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Bcpg.OpenPgp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class ChangePassForm : Form
    {
        static string? email { get; set; }

        public ChangePassForm(string emailAdress)
        {
            InitializeComponent();

            email = emailAdress;
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

        private void verifyButton_Click(object sender, EventArgs e)
        {
            MySqlConnection? connection = Connection.MySqlConnection;

            if (connection != null && !string.IsNullOrEmpty(email))
            {
                SqlQuery.ChangePassword(connection, email, emailLabel.Text);
            }
        }
    }
}
