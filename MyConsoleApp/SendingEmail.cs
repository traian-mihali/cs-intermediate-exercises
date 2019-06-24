using System;

namespace MyConsoleApp
{
    public class SendingEmail : IActivity
    {
        public void Execute()
        {
            Console.WriteLine("Sending an email..");
        }
    }
}