using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstractraction.Models
{
    public abstract class HighWayVehicle:Vehicle
    {

        public virtual string DriveStyle()
        {
            return "Kara Yolu Taşımacılığı";
        }
    }
}
