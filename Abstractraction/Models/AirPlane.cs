using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstractraction.Models
{
    //somut sınıflar atalarından gelen özelliklerin nasıl kullanıldıklarını söylemek zorundalar.
    public class AirPlane : AirWayVehicle
    {
        private string _fuelType;

        public override string FuelType
        {
            get
            {
                return "kerosen yakar";
            }
        }

        //abstract üyeleri ovveride etmek zorundayız
        public override string StartEngine()
        {
            return "yakıt geldi. pervane döndü. belli bir güce ulaşıldı.";
        }
    }
}
