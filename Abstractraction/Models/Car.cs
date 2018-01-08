using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstractraction.Models
{
    public abstract class Car:HighWayVehicle
    {
        public int DoorCount { get; set; }

        public override string DriveStyle()
        {
            return "Asfaltta sürülür";
        }

        public override string StartEngine()
        {
            return "Start tuşuna bas.Motor Sesi bekle!";
        }
    }
}
