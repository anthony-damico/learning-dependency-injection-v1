namespace dependency.injection.v1.Classes
{
    public class Person
    {
        //This is an example of 
        
        //Constructors Example of No Dependency Injection
        public Person(string name)
        {
            var logger = new Logger();
            logger.Log($@"{name} was created");
        }
        
        //Constructors Example of Dependency Injection with Concrete Implementation
        public Person(string name, Logger logger)
        {
            //No need to create a new logger class. It is passed into the constructor as a parameter
            //var logger = new Logger();
            logger.Log($@"{name} was created");
        }
    }
}