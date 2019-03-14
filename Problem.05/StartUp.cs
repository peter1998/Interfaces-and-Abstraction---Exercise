using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Problem._05
{
    class StartUp
    {
        static void Main()
        {
                 List<Id> myList = new List<Id>();
            while (true)
            {
                var Arguments = Console.ReadLine().Split().ToArray();


                if (Arguments[0]=="End")
                {
                    break;
                }

                if (Arguments.Length == 2)
                {
                    Id curRobot = new Robot(Arguments[0], Arguments[1]);
                    myList.Add(curRobot);
                }
                else if (Arguments.Length == 3)
                {
                    Id curCitizen = new Citizen(Arguments[0], int.Parse(Arguments[1]),Arguments[2]);
                    myList.Add(curCitizen);
                }
            }

        string lastDigitsFakeIds = Console.ReadLine();

            foreach (var citizen in myList)
            {
                if (citizen.Id.EndsWith(lastDigitsFakeIds))
                {
                    Console.WriteLine(citizen.Id);
                }
            }
            
        }

        
    }
}
