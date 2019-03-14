using System;
using System.Collections.Generic;
using System.Text;

namespace Problem._06
{
    public class Citizen : Inhabitant, IAge, IID, IBirthDate
    {
        public Citizen(string name,string id ,int age , DateTime birthDate) : base(name)
        {
            this.Id = Id;
            this.Age = age;
            this.BirthDate = birthDate;
        }

        public string Id { get; set; }
        public int Age { get; set; }
        public DateTime BirthDate { get; set; }
        public override string Name { get; set; }
    }
    }

