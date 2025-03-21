using MySql.Data.MySqlClient;

namespace Login.Helper;

/// <summary>
/// Helper class for executing MySQL database queries.
/// </summary>
public class QueryHelper
{
    /// <summary>
    /// Executes a non-query SQL command (INSERT, UPDATE, DELETE) on the database.
    /// </summary>
    /// <param name="connection">The MySQL connection to use.</param>
    /// <param name="query">The SQL query to execute.</param>
    /// <param name="parameterSetter">An action to set command parameters.</param>
    /// <returns>True if the command affected at least one row, otherwise false.</returns>
    public static bool ExecuteNonQuery(MySqlConnection connection, string query, Action<MySqlCommand> parameterSetter)
    {
        try
        {
            using var command = new MySqlCommand(query, connection);
            parameterSetter?.Invoke(command);
            return command.ExecuteNonQuery() > 0;
        }
        catch (Exception ex)
        {
            AppHelper.OutgoingError(ex.Message);
            return false;
        }
    }

    /// <summary>
    /// Executes a scalar SQL query that returns a single value.
    /// </summary>
    /// <param name="connection">The MySQL connection to use.</param>
    /// <param name="query">The SQL query to execute.</param>
    /// <param name="parameterSetter">An action to set command parameters.</param>
    /// <returns>The scalar result as a long integer. Returns 0 if an error occurs.</returns>
    public static long ExecuteScalar(MySqlConnection connection, string query, Action<MySqlCommand> parameterSetter)
    {
        try
        {
            using var command = new MySqlCommand(query, connection);
            parameterSetter?.Invoke(command);
            return Convert.ToInt64(command.ExecuteScalar());
        }
        catch (Exception ex)
        {
            AppHelper.OutgoingError(ex.Message);
            return 0;
        }
    }

    /// <summary>
    /// Executes a SQL query that returns a result set and processes it with the provided reader action.
    /// </summary>
    /// <typeparam name="T">The type of result to return.</typeparam>
    /// <param name="connection">The MySQL connection to use.</param>
    /// <param name="query">The SQL query to execute.</param>
    /// <param name="parameterSetter">An action to set command parameters.</param>
    /// <param name="readerAction">A function that processes the data reader and returns a result.</param>
    /// <returns>The result of the reader action. Returns default(T) if an error occurs.</returns>
    public static T ExecuteReader<T>(MySqlConnection connection, string query, Action<MySqlCommand> parameterSetter, Func<MySqlDataReader, T> readerAction)
    {
        try
        {
            using var command = new MySqlCommand(query, connection);
            parameterSetter?.Invoke(command);
            using var reader = command.ExecuteReader();
            return readerAction(reader);
        }
        catch (Exception ex)
        {
            AppHelper.OutgoingError(ex.Message);
            return default;
        }
    }
}