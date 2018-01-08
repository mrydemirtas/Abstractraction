using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstractraction.Models
{
    public class RangeRover : Car
    {
        public override string DriveStyle()
        {
            return "Arazi de veya asfaltta gider";
        }

        public override string FuelType
        {
            get
            {
                return "Diesel yakar.";
            }
        }
    }
}
