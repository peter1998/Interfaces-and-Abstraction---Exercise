using Problem._03WildFarm.Models.Foods;
using System;
using System.Collections.Generic;
using System.Text;

namespace Problem._03WildFarm.Models.Animals.Mammals
{
    public class Dog : Mammal
    {
        private const double GainValue = 0.40;

        public Dog(string name, double weight, string livingRegion)
            : base(name, weight, livingRegion)
        {
        }

        public override void Eat(Food food)
        {
            this.BaseEat(food, new List<string>() { nameof(Meat) }, GainValue);
        }

        public override string ProduceSound()
        {
            return "Woof!";
        }
    }
}
