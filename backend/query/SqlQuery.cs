using Login.util;
using MySql.Data.MySqlClient;

namespace Login.backend.query
{
    internal class SqlQuery
    {
        public static bool CreateLogin(MySqlConnection connection, string email, string password)
        {
            using (MySqlCommand command = new MySqlCommand("INSERT INTO login (email, password, code, checked) VALUES (@Email, @Password, @Code, @Checked)", connection))
            {
                command.Parameters.AddWithValue("@Email", email);
                command.Parameters.AddWithValue("@Password", password);
                command.Parameters.AddWithValue("@Code", new Random().Next(100000, 999999));
                command.Parameters.AddWithValue("@Checked", false);

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

        public static bool ConfirmEmail(MySqlConnection connection, string email)
        {
            using (MySqlCommand command = new MySqlCommand("UPDATE login SET checked = 1 WHERE email = @Email", connection))
            {
                command.Parameters.AddWithValue("@Email", email);

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

        public static bool VerifyConfirmationEmail(MySqlConnection connection, string email, string code)
        {
            using (MySqlCommand command = new MySqlCommand("SELECT code FROM login WHERE email = @Email", connection))
            {
                command.Parameters.AddWithValue("@Email", email);

                try
                {
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read() && reader["code"].ToString() == code)
                        {
                            ConfirmEmail(connection, email);
                            return true;
                        }
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

        public static bool HasConfirmedEmail(MySqlConnection connection, string email)
        {
            using (MySqlCommand command = new MySqlCommand("SELECT COUNT(*) FROM login WHERE email = @Email", connection))
            {
                command.Parameters.AddWithValue("@Email", email);

                try
                {
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read() && Convert.ToInt16(reader["checked"]) == 1)
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

        public static string GetEmailByConfirmCode(MySqlConnection connection, string code)
        {
            using (MySqlCommand command = new MySqlCommand("SELECT COUNT(*) FROM login WHERE code = @Code", connection))
            {
                command.Parameters.AddWithValue("@Code", code);

                try
                {
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                            return (string)reader["email"];
                    }
                }
                catch (Exception ex)
                {
                    Util.OutgoingError(ex.Message);
                }
            }

            return "";
        }
    }
}