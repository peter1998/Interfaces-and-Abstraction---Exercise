using System;
using System.Collections.Generic;
using System.Text;

namespace Problem._07
{
    public interface IBuyer
    {
        string Name { get; }

        int Food { get;  } 

        void BuyFood();
    }
}
