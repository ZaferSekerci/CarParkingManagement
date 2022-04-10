using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarParkingManagement
{
    class PriceList
    {
        
        public PriceList(VehicleClass vehicleClass)
        {
            switch (vehicleClass)
            {
                case VehicleClass.Sedan:
                    PriceMultiplier = 5;
                    break;
                case VehicleClass.SUV:
                    PriceMultiplier = 10;
                    break;
                case VehicleClass.Van:
                    PriceMultiplier = 15;
                    break;
                case VehicleClass.Pickup:
                    PriceMultiplier = 20;
                    break;
                default:
                    break;
            }
        }

        public VehicleClass vehicleClass { get; set; }
        public int PriceMultiplier { get; }
    }
}
