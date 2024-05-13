using System;
using dependency.injection.v1.method.Interfaces;

namespace dependency.injection.v1.method.Classes
{
    public class ConsoleLogger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine(message);
        }
    }
}