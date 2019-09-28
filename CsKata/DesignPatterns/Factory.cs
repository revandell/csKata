namespace CsKata.DesignPatterns
{
    public class Factory
    {
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
}
