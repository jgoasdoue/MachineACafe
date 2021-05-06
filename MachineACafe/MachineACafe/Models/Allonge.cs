using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MachineACafe.Models
{
    public class Allonge: Drink
    {
        public Allonge()
        {
            rawPrice = COFFEE + 2 * WATER;
        }
    }
}
