namespace dependency.injection.v1.method.Classes
{
    public class PersonFactory
    {
        public Person GetPerson(string name, string newName)
        {
            var logger = new ConsoleLogger();
            var person = new Person();
            
            person.DoSomething(name, newName, logger);

            return person;
        }
    }
}