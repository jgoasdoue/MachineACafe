namespace MachineACafe.Models
{
    public abstract class Drink
    {
        protected static readonly double COFFEE = 1;
        protected static readonly double SUGAR = 0.1;
        protected static readonly double CREAM = 0.5;
        protected static readonly double TEA = 2;
        protected static readonly double WATER = 0.2;
        protected static readonly double CHOCOLATE = 1;
        protected static readonly double MILK = 0.4;

        protected double rawPrice; 

        //Get the final price
        public double GetPrice()
        {
            return rawPrice + AddMargin(rawPrice);
        }

        //Calculate the 30% margin to the ingredients' price
        private double AddMargin(double priceOfIngredients)
        {
            return priceOfIngredients * 0.30;
        }

    }
}
