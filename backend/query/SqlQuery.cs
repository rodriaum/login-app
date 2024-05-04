using Login.util;
using MySql.Data.MySqlClient;

namespace Login.backend.query
{
    internal class SqlQuery
    {
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
    }
}
