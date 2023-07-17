using dependency.injection.v1.Interfaces;

namespace dependency.injection.v1.Classes
{
    public class PersonConstructorInjection
    {
        //Example of Constructor Injection
        public PersonConstructorInjection(string name, ILogger logger)
        {
            logger.Log($@"{name} was created");
        }
    }
}