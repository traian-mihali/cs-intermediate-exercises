using System;

namespace MyConsoleApp
{
    public class ChangingVideoStatus : IActivity
    {
        public void Execute()
        {
            Console.WriteLine("Changing the video status in the database to 'Processing'");
        }
    }
}