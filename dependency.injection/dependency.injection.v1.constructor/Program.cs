using System;
using dependency.injection.v1.constructor.Classes;

namespace dependency.injection.v1.constructor
{
    class Program
    {
        static void Main(string[] args)
        {
            var personFactory = new PersonFactory();
            var logger = new ConsoleLogger();
            personFactory.GetPerson("Anthony", logger);
        }
    }
}