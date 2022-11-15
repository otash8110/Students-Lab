namespace Singleton
{
    public sealed class DatabaseConnection
    {
        private static readonly DatabaseConnection _dbInstance = new DatabaseConnection();

        static DatabaseConnection() { }

        private DatabaseConnection() { }

        public static DatabaseConnection OpenConnection()
        {
            return _dbInstance;
        }

        public string ExecuteQuery(string query)
        {
            return null;
        }

        public void CloseConnection() { }
    }
}
