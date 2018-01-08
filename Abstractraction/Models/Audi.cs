using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstractraction.Models
{
    //sealed sınıflarda kalıtım alt sınıflara verilemez.
    public sealed class Audi : Car
    {
        public string Brand {
            get {
                return "Audi";
            }
        }

        public int ModelYear { get; set; }
        public string Model { get; set; }

        public override string FuelType
        {
            get
            {
                return "Benzin yakar";
            }
        }
    }
}
