using System.IO;
using dependency.injection.v1.constructor.Interfaces;

namespace dependency.injection.v1.constructor.Classes
{
    public class FileLogger : ILogger
    {
        public void Log(string message)
        {
            File.AppendText(message);
        }
    }
}