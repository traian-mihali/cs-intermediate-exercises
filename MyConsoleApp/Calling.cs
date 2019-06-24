using System;

namespace MyConsoleApp
{
    public class Calling : IActivity
    {
        public void Execute()
        {
            Console.WriteLine("Calling a web service..");
        }
    }
}