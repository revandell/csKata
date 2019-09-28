using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWarsCata
{
    class Builder
    {
        static void Main(string[] args)
        {
            var pf = new PersonFactory();
            var p1 = pf.CreatePerson("Aro");
            var p2 = pf.CreatePerson("Vro");
        }
    }

    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class PersonFactory
    {
        private static int _id = 0;
        public Person CreatePerson(string name)
        {
            Person p = new Person() { Name = name, Id = _id };
            _id++;

            return p;
        }
    }
}