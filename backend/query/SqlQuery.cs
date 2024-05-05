using Login.util;
using MySql.Data.MySqlClient;

namespace Login.backend.query
{
    internal class SqlQuery
    {
        public static bool CreateLogin(MySqlConnection connection, string email, string password)
        {
            using (MySqlCommand command = new MySqlCommand("INSERT INTO login (email, password) VALUES (@Email, @Password)", connection))
            {
                command.Parameters.AddWithValue("@Email", email);
                command.Parameters.AddWithValue("@Password", password);

                try
                {
                    if (command.ExecuteNonQuery() > 0)
                        return true;
                }
                catch (Exception ex)
                {
                    Util.OutgoingError(ex.Message);
                }
            }

            return false;
        }

        public static bool VerifyLogin(MySqlConnection connection, string email, string password)
        {
            using (MySqlCommand command = new MySqlCommand("SELECT password FROM login WHERE email = @Email", connection))
            {
                command.Parameters.AddWithValue("@Email", email);

                try
                {
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read() && reader["password"].ToString() == password)
                            return true;
                    }
                }
                catch (Exception ex)
                {
                    Util.OutgoingError(ex.Message);
                }
            }

            return false;
        }

        public static bool HasLogin(MySqlConnection connection, string email)
        {
            using (MySqlCommand command = new MySqlCommand("SELECT COUNT(*) FROM login WHERE email = @Email", connection))
            {
                command.Parameters.AddWithValue("@Email", email);

                try
                {
                    if ((long)command.ExecuteScalar() > 0)
                        return true;
                }
                catch (Exception ex)
                {
                    Util.OutgoingError(ex.Message);
                }
            }

            return false;
        }
    }
}