using dependency.injection.v1.Interfaces;

namespace dependency.injection.v1.Classes
{
    public class PersonPropertyInjection
    {
        //Properties / variables
        public ILogger Logger { get; set; } // use uppercase because its a property
        
        //Example of property injection
        public void DoSomething()
        {
            Logger.Log("DoSomethingPropertyInjection");
        }
    }
}