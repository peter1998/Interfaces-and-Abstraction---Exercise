namespace Problem._06
{
using System;
    using System.Collections.Generic;

    class StartUp
    {
        static void Main()
        {
            List<IBirthDate> birthDates = new List<IBirthDate>();

            string input = Console.ReadLine();

            while (input != "End")
            {
                string[] data = input.Split();

                switch (data[0])
                {
                    case "Citizen":
                        if (data.Length == 5)
                        {
                            //Citizen Pesho 22 9010101122 10 / 10 / 1990
                            DateTime date = DateTime.ParseExact(data[4], "dd/MM/yyyy", null);
                            birthDates.Add(new Citizen(name: data[1], id: data[3], age: int.Parse(data[2]), birthDate: date));
                        }
                        break;
                    case "Pet":
                        if (data.Length == 3)
                        {
                            //Pet Sharo 13 / 11 / 2005
                            DateTime date1 = DateTime.ParseExact(data[2], "dd/MM/yyyy", null);
                            birthDates.Add(new Pet(name: data[1], birthDate: date1));

                        }
                        break;
                }
                input = Console.ReadLine();
            }
            string year = Console.ReadLine();

            foreach (var birthDate in birthDates)
            {
                if (birthDate.BirthDate.Year == int.Parse(year))
                {
                    Console.WriteLine(birthDate.BirthDate.Date.ToString("dd/MM/yyyy"));
                    //Console.WriteLine($"{birthDate.BirthDate.Day}/{birthDate.BirthDate.Month}/{birthDate.BirthDate.Year}");
                }
            }
        }
    }
}
