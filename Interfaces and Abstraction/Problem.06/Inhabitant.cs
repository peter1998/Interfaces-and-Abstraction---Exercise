using System;
using System.Collections.Generic;
using System.Text;

namespace Problem._06
{
   public abstract class Inhabitant
    {
        public Inhabitant(string name)
        {
            this.Name = name;
        }

        public abstract string Name { get; set; }
    }

    
}
