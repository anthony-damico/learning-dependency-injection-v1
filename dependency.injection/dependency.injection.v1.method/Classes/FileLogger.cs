using System.IO;
using dependency.injection.v1.method.Interfaces;

namespace dependency.injection.v1.method.Classes
{
    public class FileLogger : ILogger
    {
        public void Log(string message)
        {
            File.AppendText(message);
        }
    }
}