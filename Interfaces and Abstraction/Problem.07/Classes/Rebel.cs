using System;
using System.Collections.Generic;
using System.Text;

namespace Problem._07
{
    public class Rebel : IAge,IBuyer
    {
        
        private string group;

        public Rebel(string name , int age , string group)
            
        {
            this.Name = name;
            this.Age = age;
            this.Group = group;
        }

        public string Group
        {
            get { return group; }
            set { group = value; }
        }

        public int Age { get; private set; }

        public int Food { get; private set; }

        public string Name { get; private set; }

        public void BuyFood()
        {
            this.Food += 5;
        }
    }
}
