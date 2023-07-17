using System;
using dependency.injection.v1.property.Classes;

namespace dependency.injection.v1.property
{
    class Program
    {
        static void Main(string[] args)
        {
            var personFactory = new PersonFactory();
            personFactory.GetPerson("Anthony", "Antonio");
        }
    }
}