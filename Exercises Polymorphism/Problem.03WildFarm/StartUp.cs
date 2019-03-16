using Problem._03WildFarm.Models;
using Problem._03WildFarm.Models.Animals;
using Problem._03WildFarm.Models.Foods;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem._03WildFarm
{
    class StartUp
    {
        static void Main()
        {
            List<Animal> animals = new List<Animal>();

            string input = "";
            while ((input=Console.ReadLine()) !="End")
            {
                string[] animalArgs = input.Split();

                Animal animal = AnimalFactory.Create(animalArgs);

                    animals.Add(animal);
                string[] foodArgs = Console.ReadLine().Split();

                Food food = FoodFactory.Create(foodArgs);

                Console.WriteLine(animal.ProduceSound());
                //animal.ProduceSound();

                try
                {
                    animal.Eat(food);
                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.Message);
                }
            //string input = Console.ReadLine();
            }

            foreach (var animal in animals)
            {
                Console.WriteLine(animal.ToString());
            }
        }
    }
}
