using System;
using System.Collections.Generic;
using System.Text;

namespace Problem._05
{
    public class Robot : Id
    {
        private string model;

        public Robot(string model,string id)
        {
            this.Model = model;
            this.Id = id;
        }

        //IDTO E OBSHTO 

        public string Model
        {
            get { return model; }
            set { model = value; }
        }

        public string Id { get; private set; }
    }
}
