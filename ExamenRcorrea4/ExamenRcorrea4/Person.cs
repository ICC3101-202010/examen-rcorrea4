using System;
using System.Collections.Generic;
using System.Text;

namespace ExamenRcorrea4
{
    public abstract class Person
    {
        public string completeName;
        public string id;
        public int age;

        public string CompleteName { get => completeName; set => completeName = value; }
        public string Id { get => id; set => id = value; }
        public int Age { get => age; set => age = value; }

        public Person(string completeName,string id, int age)
        {
            this.completeName = completeName;
            this.id = id;
            this.age = age;
        }
    }
}
