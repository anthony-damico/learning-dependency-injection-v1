namespace dependency.injection.v1.Classes
{
    public class PersonFactory
    {
        //Example of Constructor Injection
        PersonConstructorInjection GetPersonConstructorInjection()
        {
            var logger = new ConsoleLogger();
            return new PersonConstructorInjection("Anthony", logger);
        }

        //Example of Method Injection
        PersonMethodInjection GetPersonMethodInjection()
        {
            var logger = new ConsoleLogger();
            var person = new PersonMethodInjection();
            
            person.DoSomething(logger);

            return person;
        }

        //Example of Property Injection
        PersonPropertyInjection GetPersonPropertyInjection()
        {
            var logger = new ConsoleLogger();

            var person = new PersonPropertyInjection()
            {
                Logger = logger
            };
            
            person.DoSomething();

            return person;
        }
    }
}