using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MachineACafe.Models
{
    public class Expresso: Drink
    {
        public Expresso()
        {
            rawPrice = COFFEE + WATER;
        }
    }
}
