using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarParkingManagement
{
    class ParkingLot
    {
        public string ParkingLotName { get; set; }
        public decimal TotalIncome { get; set; }
        public int MaximumCarCapacity { get; set; }
        public List<Customer> listOfCarsIn = new List<Customer>(); 

    }
}
