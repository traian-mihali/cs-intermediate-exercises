using System;

namespace MyConsoleApp
{
    public class SqlConnection : DbConnection
    {
        public SqlConnection(string connectionString) 
            : base(connectionString)
        {
        }

        public override void OpenConnection()
        {
            Console.WriteLine("Connection to " + this.ConnectionString + " opened");
        }

        public override void CloseConnection()
        {
            Console.WriteLine("Connection closed.");
        }
    }
}