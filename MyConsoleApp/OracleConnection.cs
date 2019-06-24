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
            Console.WriteLine("OracleConnection is opened.");
        }

        public override void CloseConnection()
        {
            Console.WriteLine("OracleConnection is closed.");
        }
    }
}