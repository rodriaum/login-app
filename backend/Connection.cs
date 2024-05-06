using MySql.Data.MySqlClient;
using Login.util;

namespace Login.backend
{
    internal class Connection
    {
        public static MySqlConnection? MySqlConnection;

        public static MySqlConnection Init(string databaseName, string user, string password)
        {
            MySqlConnection connection = new MySqlConnection($"Server=127.0.0.1;Database={databaseName};Uid={user};Pwd={password};");

            try
            {
                connection.Open();

            }
            catch (Exception ex)
            {
                Util.OutgoingError("Erro: " + ex.Message);
                Application.Exit();
            }

            MySqlConnection = connection;

            return connection;
        }

        public static MySqlConnection Init() => Init("application", "root", "");
    }
}

