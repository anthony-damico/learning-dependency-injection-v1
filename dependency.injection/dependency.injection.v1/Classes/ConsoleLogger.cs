using System;
using dependency.injection.v1.Interfaces;

namespace dependency.injection.v1.Classes
{
    public class ConsoleLogger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine(message);
        }
    }
}