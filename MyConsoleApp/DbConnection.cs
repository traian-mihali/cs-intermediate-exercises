using System;

namespace MyConsoleApp
{
    public abstract class DbConnection
    {
        public string ConnectionString { get; }
        public TimeSpan Timeout { get; }

        public DbConnection(string connectionString)
        {
            if(String.IsNullOrWhiteSpace(connectionString))
                throw new ArgumentNullException();

            this.ConnectionString = connectionString;
            this.Timeout = new TimeSpan(0, 0, 0, 10);
        }

        public abstract void OpenConnection();
        public abstract void CloseConnection();
    }
}