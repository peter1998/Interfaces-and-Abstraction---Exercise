﻿using Problem._03WildFarm.Models.Foods;
using System;
using System.Collections.Generic;
using System.Text;

namespace Problem._03WildFarm.Models.Animals.Felines
{
    public class Cat : Feline
    {
        private const double GainValue = 0.3;

        public Cat(string name, double weight, string livingRegion, string breed) : base(name, weight, livingRegion, breed)
        {
        }

        public override void Eat(Food food)
        {
            this.BaseEat(food, new List<string>() { nameof(Vegetable), nameof(Meat) }, GainValue);
        }

        public override string ProduceSound()
        {
            return "Meow";
        }
    }
}
