using System;

namespace Problem._03
{
    class Program
    {
        static void Main()
        {
            string driverName = Console.ReadLine();

            Ferrari ferrari = new Ferrari(driverName);

            Console.WriteLine(ferrari.ToString());
        }
    }
}
