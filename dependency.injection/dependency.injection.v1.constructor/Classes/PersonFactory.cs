using dependency.injection.v1.constructor.Interfaces;

namespace dependency.injection.v1.constructor.Classes
{
    public class PersonFactory
    {
        public Person GetPerson(string name, ILogger logger)
        {
            //var logger = new ConsoleLogger();
            return new Person(name, logger);
        }
    }
}