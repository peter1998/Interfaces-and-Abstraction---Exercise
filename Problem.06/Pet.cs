using System;
using System.Collections.Generic;
using System.Text;

namespace Problem._06
{
    public class Pet : Inhabitant, IBirthDate
    {
        public DateTime BirthDate { get; set; }
        public override string Name { get; set; }

        public Pet(string name,DateTime birthDate):base(name)
        {
            this.BirthDate = birthDate;
        }
    }
}
