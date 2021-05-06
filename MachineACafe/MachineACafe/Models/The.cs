using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MachineACafe.Models
{
    public class The: Drink
    {
        public The()
        {
            rawPrice = TEA + 2 * WATER;
        }
    }
}
