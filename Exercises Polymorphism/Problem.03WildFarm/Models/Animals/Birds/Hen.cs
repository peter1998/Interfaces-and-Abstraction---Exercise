using Problem._03WildFarm.Models.Foods;
using System.Collections.Generic;

namespace Problem._03WildFarm.Models.Animals.Birds
{
    public class Hen : Bird
    {
        private const double GainValue = 0.35;

        public Hen(string name, double weight, double wingSize) 
            : base(name, weight, wingSize)
        {
        }

        public override void Eat(Food food)
        {
            this.BaseEat(food, new List<string>() { nameof(Vegetable), nameof(Fruit), nameof(Seeds),nameof(Meat) }, GainValue);
        }

        public override string ProduceSound()
        {
            return "Cluck";
        }
    }
}
