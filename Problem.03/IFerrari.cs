using System;
using System.Collections.Generic;
using System.Text;

namespace Problem._03
{
    public interface IFerrari
    {
        string Model { get; }
        string Driver { get; }
        string PushBrakes();
        string Gas();

    }
}
