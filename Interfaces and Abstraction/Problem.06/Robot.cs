using System;
using System.Collections.Generic;
using System.Text;

namespace Problem._06
{
    public class Robot : Inhabitant, IID
    {
        public string Id { get; set; }
        public override string Name { get; set; }


        public Robot(string name,string id) : base(name)
        {
            this.Id = id;
        }
    }
}
