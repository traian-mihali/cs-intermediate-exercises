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
            Console.WriteLine("SqlConnection is opened.");
        }

        public override void CloseConnection()
        {
            Console.WriteLine("SqlConnection is closed.");
        }
    }
}