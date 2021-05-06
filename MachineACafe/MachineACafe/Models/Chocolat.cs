using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
