using System.Text.RegularExpressions;
using Login.Database;
using Login.Database.Query;
using Login.Helper;
using Login.Login.Templates;
using MySql.Data.MySqlClient;

namespace Login.Forms;

public partial class ConfirmEmailForm : TemplateForm
{
    public ConfirmEmailForm()
    {
        InitializeComponent();
    }

    private void RegisterButton_Click(object sender, EventArgs e)
    {
        new LoginForm().Show();
        this.Hide();
    }

    private async void VerifyButton_Click(object sender, EventArgs e)
    {
        MySqlConnection? connection = ConnectionDB.MySqlConnection;
        Button button = verifyButton;

        if (button != null && connection != null)
        {
            string code = codeTextBox.Text;
            string? email = QueryDB.GetEmailByConfirmCode(connection, code);

            // Regex: Verifica se é dígito.
            if (string.IsNullOrEmpty(code) && !Regex.IsMatch(code, @"^[0-9]+$"))
            {
                AppHelper.DebugLabel(codeDebugLabel, "Insira um código válido.");
            }
            else
            {
                if (QueryDB.VerifyConfirmationEmail(connection, email, code) && QueryDB.ConfirmEmail(connection, email))
                {
                    AppHelper.DebugLabel(confirmEmailDebugLabel, "E-mail confirmado com sucesso.");

                    await Task.Delay(1000);

                    new LoginForm(email: email).Show();
                    this.Hide();
                }
                else
                {
                    AppHelper.DebugLabel(confirmEmailDebugLabel, "Não foi possível confirmar o seu registro.");
                }
            }
          
        }
        else
        {
            AppHelper.OutgoingError("Botão ou conexão com o banco de dados nulo.");
        }
    }
}
