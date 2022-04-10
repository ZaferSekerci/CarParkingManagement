using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarParkingManagement
{
    class Car
    {

        public string Plate { get; set; }
        public VehicleClass VehicleClass { get; set; } // bunu "enum" dan al

    }


    public enum VehicleClass
    {
        Sedan = 1,
        SUV = 2,
        Van = 3,
        Pickup = 4
    }
}
