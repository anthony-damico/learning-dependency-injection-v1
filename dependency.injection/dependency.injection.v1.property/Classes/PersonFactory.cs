namespace dependency.injection.v1.property.Classes
{
    public class PersonFactory
    {
        public Person GetPerson(string name, string newName)
        {
            var logger = new ConsoleLogger();

            var person = new Person()
            {
                Logger = logger
            };
            
            person.DoSomething(name, newName);

            return person;
        }
    }
}