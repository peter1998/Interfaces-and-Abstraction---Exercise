using System;
using System.Collections.Generic;
using System.Text;

namespace Problem._05
{
    public class Citizen : Id
    {
        private string name;
        private int age;

        public Citizen(string name , int age , string id)
        {
            this.Name = name;this.Age = age;this.Id = id;
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Id { get; private set; }
    }
}
