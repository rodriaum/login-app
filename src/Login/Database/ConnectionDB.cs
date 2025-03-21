using Login.Helper;
using Login.Login;
using MySql.Data.MySqlClient;

namespace Login.Database;

internal class ConnectionDB
{
    public static MySqlConnection? MySqlConnection { get; private set; }

    public static MySqlConnection Init(string database, string user, string password)
    {
        string baseConnectionString = $"Server=127.0.0.1;Uid={user};Pwd={password};Pooling=true;";
        string dbConnectionString = $"{baseConnectionString}Database={database};";

        try
        {
            using (MySqlConnection tempConnection = new MySqlConnection(baseConnectionString))
            {
                tempConnection.Open();
                // Checks if the database exists
                using (MySqlCommand cmd = new MySqlCommand($"CREATE DATABASE IF NOT EXISTS `{database}`;", tempConnection))
                {
                    cmd.ExecuteNonQuery();
                }
            }

            // Now connect to the specific database
            MySqlConnection connection = new MySqlConnection(dbConnectionString);
            connection.Open();

            MySqlConnection = connection;

            // Create all tables defined in TablesToCreate list
            CreateTables(connection);

            return connection;
        }
        catch (Exception ex)
        {
            AppHelper.OutgoingError("Erro na Inicialização do MySQL:\n" + ex.Message);
            throw;
        }
    }

    private static void CreateTables(MySqlConnection connection)
    {
        try
        {
            foreach (string table in Constant.TablesToCreate)
            {
                using (MySqlCommand cmd = new MySqlCommand(table, connection))
                {
                    cmd.ExecuteNonQuery();
                }
            }
            Console.WriteLine("Todas as tabelas foram verificadas/criadas com sucesso.");
        }
        catch (Exception ex)
        {
            AppHelper.OutgoingError("Erro na criação das tabelas:\n" + ex.Message);
            throw;
        }
    }

    public static MySqlConnection Init() => Init("application", "root", "");
}