using System.IO;
using dependency.injection.v1.property.Interfaces;

namespace dependency.injection.v1.property.Classes
{
    public class Person
    {
        //Properties / variables
        public ILogger Logger { get; set; } // use uppercase because its a property
        
        //Example of property injection
        public void DoSomething(string name, string newName)
        {
            var solutionName = Path.GetFileName(System.Diagnostics.Process.GetCurrentProcess().MainModule.FileName);
            
            //Note the Captial "L" indicating its using the publi property
            Logger.Log($@"{name} was changed to {newName} using the {solutionName.Replace(".exe", "")} solution");
        }
    }
}