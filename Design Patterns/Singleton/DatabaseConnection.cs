namespace Singleton
{
    public sealed class DatabaseConnection
    {
        private static readonly DatabaseConnection dbInstance = new DatabaseConnection();
        private static string privateConnectionString;

        static DatabaseConnection() { }

        private DatabaseConnection() { }

        public static DatabaseConnection OpenConnection(string connectionString)
        {
            privateConnectionString = connectionString;
            return dbInstance;
        }

        public string ExecuteQuery(string query)
        {
            return null;
        }

        public void CloseConnection() { }
    }
}
