using System.IO;
using dependency.injection.v1.constructor.Interfaces;

namespace dependency.injection.v1.constructor.Classes
{
    public class Person
    {
        public Person(string name, ILogger logger)
        {
            var solutionName = Path.GetFileName(System.Diagnostics.Process.GetCurrentProcess().MainModule.FileName);
            logger.Log($@"{name} was created using the {solutionName.Replace(".exe", "")} solution");
        }
    }
}