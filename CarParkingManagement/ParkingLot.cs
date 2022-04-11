using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarParkingManagement
{
    class ParkingLot
    {
        public bool CheckAvailability()
        {
            return TotalIncome != MaximumCarCapacity;
        }


        public string CapacityCustomerRatio()
        {
            if (TotalIncome >= MaximumCarCapacity * 0.5m)
            {
                return "red";
            }
            else if (TotalIncome >= MaximumCarCapacity * 0.10m)
            {
                return "yellow";
            }
            else
            {
                return "green";
            }
        }

        public string ParkingLotName { get; set; }
        public decimal TotalIncome { get; set; }
        public decimal MaximumCarCapacity { get; set; }
        public List<Customer> listOfCarsIn = new List<Customer>();

    }
}
