using System;

namespace MyConsoleApp
{
    public class DbCommand
    {
        private readonly DbConnection _dbConnection;
        public string Instruction { get; set; }

        public DbCommand(DbConnection dbConnection, string instruction)
        {
            if(dbConnection == null)
                throw  new ArgumentNullException();

            if(String.IsNullOrWhiteSpace(instruction))
                throw  new ArgumentNullException();

            this._dbConnection = dbConnection;
            this.Instruction = instruction;
        }

        public void Execute()
        {
            _dbConnection.OpenConnection();

            Console.WriteLine("An instruction is send to the Database.");

            _dbConnection.CloseConnection();
        }
    }
}