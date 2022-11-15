namespace Singleton
{
    public class Program
    {
        public static void Main(string[] args)
        {
            DatabaseConnection db = DatabaseConnection.OpenConnection();

            db.ExecuteQuery("Some query");
        }
    }
}

