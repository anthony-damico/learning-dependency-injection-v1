using System.IO;
using dependency.injection.v1.method.Interfaces;

namespace dependency.injection.v1.method.Classes
{
    public class Person
    {
        //Example of method Injection
        public void DoSomething(string name, string newName, ILogger logger)
        {
            var solutionName = Path.GetFileName(System.Diagnostics.Process.GetCurrentProcess().MainModule.FileName);
            logger.Log($@"{name} was changed to {newName} using the {solutionName.Replace(".exe", "")} solution");
        }
    }
}