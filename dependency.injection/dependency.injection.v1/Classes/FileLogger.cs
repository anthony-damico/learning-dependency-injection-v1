using System.IO;
using dependency.injection.v1.Interfaces;

namespace dependency.injection.v1.Classes
{
    public class FileLogger : ILogger
    {
        public void Log(string message)
        {
            File.AppendText(message);
        }
    }
}