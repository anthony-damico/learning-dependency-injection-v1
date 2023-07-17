using System;
using dependency.injection.v1.property.Interfaces;

namespace dependency.injection.v1.property.Classes
{
    public class ConsoleLogger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine(message);
        }
    }
}