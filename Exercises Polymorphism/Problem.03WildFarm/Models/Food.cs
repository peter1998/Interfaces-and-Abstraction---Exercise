using System;
using System.Collections.Generic;
using System.Text;

namespace Problem._03WildFarm.Models
{
    public abstract class Food
    {

        public Food(int quantity)
        {
            this.Quantity = quantity;
        }

        public int Quantity { get;  }
    }
}
