using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace Problem._07
{
    class StartUp
    {
        static void Main()
        {
            int PeopleLines = int.Parse(Console.ReadLine());

            

            List<IBuyer> people = new List<IBuyer>();

            for (int i = 0; i < PeopleLines; i++)
            {
                var parameters = Console.ReadLine().Split().ToArray();
                string name = parameters[0];
                int age = int.Parse(parameters[1]);

                if (parameters.Length==4)
                {
                    string id = parameters[2];
                    DateTime birth = DateTime.ParseExact(parameters[3], "dd/MM/yyyy",null);
                    IBuyer citizen = new Citizen(name, id, age, birth);
                    people.Add(citizen);
                }
                else
                {
                    string group = parameters[2];
                    IBuyer rebel = new Rebel(name, age, group);
                    people.Add(rebel);
                }
                //todo

            }


            while (true)
            {
                string name = Console.ReadLine();
                if (name=="End")
                {
                    break;
                }

                if (people.Exists(e=>e.Name==name))
                {
                    var buyer = people.Find(e => e.Name == name);
                    buyer.BuyFood();
                }
                //TODO
            }
            Console.WriteLine(people.Sum(e=>e.Food));
        }
    }
}
