using System;
using System.Linq;

namespace Problem._04
{
    class StartUp
    {
        static void Main()
        {
            var phoneNumbers = Console.ReadLine().Split().ToArray();
            var sitesToVisit = Console.ReadLine().Split().ToArray();

            SmartPhone Nokia = new SmartPhone("Nokia");

            for (int i = 0; i < phoneNumbers.Length; i++)
            {
                try
                {
                    
                    Console.WriteLine(Nokia.Calling(phoneNumbers[i]));
                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.Message);
                }
            }
            for (int i = 0; i < sitesToVisit.Length; i++)
            {
                try
                {
                    Console.WriteLine(Nokia.Browsing(sitesToVisit[i]));
                    
                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}
