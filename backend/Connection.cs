using MySql.Data.MySqlClient;
using Login.util;

namespace Login.backend
{
    internal class Connection
    {
        public static MySqlConnection? MySqlConnection;

        public static MySqlConnection Init(string databaseName, string user, string password)
        {
            MySqlConnection connection = new MySqlConnection($"Server=127.0.0.1;Database={databaseName};Uid={user};Pwd={password};Pooling=true;");

            try
            {
                connection.Open();

            }
            catch (Exception ex)
            {
                Util.OutgoingError("Inicialização MySql:\nErro: " + ex.Message);
            }

            MySqlConnection = connection;

            return connection;
        }

        public static MySqlConnection Init() => Init("application", "root", "");
    }
}

