using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MachineACafe.Models
{
    public class Capuccino:Drink
    {
        public Capuccino()
        {
            rawPrice = COFFEE + CHOCOLATE + WATER + CREAM;
        }
    }
}
