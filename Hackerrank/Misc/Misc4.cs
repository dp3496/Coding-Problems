namespace Hackerrank.Misc
{
    public class Fruit
    {
        public string Group { get; set; }
        public string CommanName { get; set; }
        public string ScientificName { get; set; }
        public double Weight { get; set; }
        public double Calories { get; set; }

        public void GetFruitCalories(int calories)
        {
            Calories = calories;
        }
    }

    public class FruitFactory
    {
        public double Calories { get; }
        public double Weight { get; }

        public Fruit Create()
        {
            return new Fruit
            {
                Group = "Mangoes",
                CommanName = "Bangenapalli",
                Weight = GetFruitWeight(),
                Calories = GetFruitCalories()
            };
        }

        private double GetFruitCalories()
        {
            return 2;
        }

        private double GetFruitWeight()
        {
            return 2.0;
        }
    }
}