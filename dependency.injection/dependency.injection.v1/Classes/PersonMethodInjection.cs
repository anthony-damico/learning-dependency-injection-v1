using dependency.injection.v1.Interfaces;

namespace dependency.injection.v1.Classes
{
    public class PersonMethodInjection
    {
        //Example of method Injection
        public void DoSomething(ILogger logger)
        {
            logger.Log("DoSomethingMethodInjection");
        }
    }
}