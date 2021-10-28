using System;
using Newtonsoft.Json;

namespace cSharp9
{
    public class Init
    {
        public Init()
        {
            var p1 = new Person() { City = "Bs As" };
            Console.WriteLine(JsonConvert.SerializeObject(p1));

            Person p2 = new();
            Person p3 = new("Emiliano");
        }
    }

    public class Person
    {
        private readonly string _city = "";

        public Person()
        {

        }

        public Person(string firstName)
        {
            this.FirstName = firstName;
        }

        public string FirstName { get; init; }
        public string LastName { get; set; }

        public string City
        {
            get => this._city;
            init => this._city = value;
        }
    }
}