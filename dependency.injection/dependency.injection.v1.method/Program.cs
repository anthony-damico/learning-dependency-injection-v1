using System;
using dependency.injection.v1.method.Classes;

namespace dependency.injection.v1.method
{
    class Program
    {
        static void Main(string[] args)
        {
            var personFactory = new PersonFactory();
            personFactory.GetPerson("Anthony", "Tony");
        }
    }
}