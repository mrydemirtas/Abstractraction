using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstractraction.Models
{
    public class Bus : HighWayVehicle
    {
        public override string FuelType
        {
            get
            {
                return "Motorin";
            }
        }

        public override string StartEngine()
        {
            return "Kontağı çevir.";
        }
    }
}
