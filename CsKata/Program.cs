using System;

using static CsKata.DesignPatterns.Builder;
using static CsKata.DesignPatterns.Factory;

namespace CsKata
{
    class Builder
    {
        static void Main(string[] args)
        {
            // use builder
            var cb = new CodeBuilder("Person").AddField("Name", "string").AddField("Age", "int");
            Console.WriteLine(cb);

            // use factory
            var pf = new PersonFactory();
            var p1 = pf.CreatePerson("Aro");
            var p2 = pf.CreatePerson("Vro");
        }
    }
}