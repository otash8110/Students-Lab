namespace Singleton
{
    public class DatabaseConnection
    {
        private static DatabaseConnection _dbInstance;

        private DatabaseConnection() { }

        public static DatabaseConnection OpenConnection()
        {
            if (_dbInstance == null)
            {
                _dbInstance = new DatabaseConnection();
            }
            return _dbInstance;
        }

        public string ExecuteQuery(string query)
        {
            return null;
        }

        public void CloseConnection()
        {
            return;
        }
    }
}
