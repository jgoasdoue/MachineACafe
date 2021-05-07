namespace MachineACafe.Models
{
    public class Chocolat:Drink
    {
        public Chocolat()
        {
            rawPrice = 3 * CHOCOLATE + 2 * MILK + WATER + SUGAR;
        }
    }
}
