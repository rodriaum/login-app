using Login.Helper;
using MySql.Data.MySqlClient;

namespace Login.Database.Query;

public class QueryDB
{
    public static bool CreateLogin(MySqlConnection connection, string email, string password, string code)
    {
        const string query = "INSERT INTO login (email, password, code, checked) VALUES (@Email, @Password, @Code, @Checked)";
        return QueryHelper.ExecuteNonQuery(connection, query, (cmd) => {
            cmd.Parameters.AddWithValue("@Email", email);
            cmd.Parameters.AddWithValue("@Password", password);
            cmd.Parameters.AddWithValue("@Code", code);
            cmd.Parameters.AddWithValue("@Checked", false);
        });
    }

    public static bool ChangePassword(MySqlConnection connection, string email, string newPassword)
    {
        const string query = "UPDATE login SET password = @Password WHERE email = @Email";
        return QueryHelper.ExecuteNonQuery(connection, query, (cmd) => {
            cmd.Parameters.AddWithValue("@Email", email);
            cmd.Parameters.AddWithValue("@Password", newPassword);
        });
    }

    public static bool RemoveLoginByEmail(MySqlConnection connection, string email)
    {
        const string query = "DELETE FROM login WHERE email = @Email";
        return QueryHelper.ExecuteNonQuery(connection, query, (cmd) => cmd.Parameters.AddWithValue("@Email", email));
    }

    public static bool ConfirmEmail(MySqlConnection connection, string email)
    {
        const string query = "UPDATE login SET checked = 1 WHERE email = @Email";
        return QueryHelper.ExecuteNonQuery(connection, query, (cmd) => cmd.Parameters.AddWithValue("@Email", email));
    }

    public static bool VerifyLogin(MySqlConnection connection, string email, string password)
    {
        const string query = "SELECT password FROM login WHERE email = @Email";
        return QueryHelper.ExecuteReader(connection, query, (cmd) => cmd.Parameters.AddWithValue("@Email", email),
            (reader) => reader.Read() && reader["password"].ToString() == password);
    }

    public static bool VerifyConfirmationEmail(MySqlConnection connection, string email, string code)
    {
        const string query = "SELECT code FROM login WHERE email = @Email";
        return QueryHelper.ExecuteReader(connection, query, (cmd) => cmd.Parameters.AddWithValue("@Email", email),
            (reader) => reader.Read() && reader["code"].ToString() == code);
    }

    public static bool HasLogin(MySqlConnection connection, string email)
    {
        const string query = "SELECT COUNT(*) FROM login WHERE email = @Email";
        return QueryHelper.ExecuteScalar(connection, query, (cmd) => cmd.Parameters.AddWithValue("@Email", email)) > 0;
    }

    public static bool HasConfirmedEmail(MySqlConnection connection, string email)
    {
        const string query = "SELECT checked FROM login WHERE email = @Email";
        return QueryHelper.ExecuteReader(connection, query, (cmd) => cmd.Parameters.AddWithValue("@Email", email),
            (reader) => reader.Read() && Convert.ToBoolean(reader["checked"]));
    }

    public static string? GetEmailByConfirmCode(MySqlConnection connection, string code)
    {
        const string query = "SELECT email FROM login WHERE code = @Code";
        return QueryHelper.ExecuteReader(connection, query, (cmd) => cmd.Parameters.AddWithValue("@Code", code),
            (reader) => reader.Read() ? reader["email"].ToString() : "");
    }

    public static string? GetConfirmCodeByEmail(MySqlConnection connection, string email)
    {
        const string query = "SELECT code FROM login WHERE email = @Email";
        return QueryHelper.ExecuteReader(connection, query, (cmd) => cmd.Parameters.AddWithValue("@Email", email),
            (reader) => reader.Read() ? reader["code"].ToString() : "");
    }

    public static List<string> GetEmails(MySqlConnection connection)
    {
        const string query = "SELECT email FROM login";
        List<string> emails = new List<string>();
        QueryHelper.ExecuteReader(connection, query, null, (reader) =>
        {
            while (reader.Read())
            {
                string? email = reader["email"].ToString();
                if (string.IsNullOrWhiteSpace(email)) continue;

                emails.Add(email);
            }

            return false;
        });
        return emails;
    }
}