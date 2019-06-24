using System;

namespace MyConsoleApp
{
    public class OracleConnection : DbConnection
    {
        public OracleConnection(string connectionString)
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