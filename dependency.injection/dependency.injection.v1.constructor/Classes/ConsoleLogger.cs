using System;
using dependency.injection.v1.constructor.Interfaces;

namespace dependency.injection.v1.constructor.Classes
{
    public class ConsoleLogger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine(message);
        }
    }
}