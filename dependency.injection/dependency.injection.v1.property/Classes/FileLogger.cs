using System.IO;
using dependency.injection.v1.property.Interfaces;

namespace dependency.injection.v1.property.Classes
{
    public class FileLogger : ILogger
    {
        public void Log(string message)
        {
            File.AppendText(message);
        }
    }
}