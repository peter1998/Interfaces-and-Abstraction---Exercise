using System;
using System.Collections.Generic;
using System.Text;

namespace Problem._07
{
    public class Citizen :  IAge, IID, IBirthDate,IBuyer
    {
        public Citizen(string name,string id ,int age , DateTime birthDate) 
        {
            this.Name = name;
            this.Id = Id;
            this.Age = age;
            this.BirthDate = birthDate;
        }

        public string Id { get; private set; }

        public int Age { get; private set; }

        public DateTime BirthDate { get; private set; }
        
        public int Food { get; private set; } = 0;

        public string Name { get; private set; }

        public void BuyFood()
        {
            this.Food += 10;
        }
    }
}

