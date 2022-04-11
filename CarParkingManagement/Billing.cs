using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// customer buraya çekilmeli saatler sebebiyle
//date time işlemleri çıkarma toplama
// ctor customer çek

namespace CarParkingManagement
{
    class Billing
    {
        public Billing(Customer customer,PriceList priceList)
        {
            PriceMultiplier = priceList.PriceMultiplier;
            TimeSpan SpentTime = customer.ExitTime - customer.EntryTime;

            int Days = Convert.ToInt32(SpentTime.Days);
            int Hours = Convert.ToInt32(SpentTime.Hours);
            int Minutes = Convert.ToInt32(SpentTime.Minutes);

            int TotalHours = (Days * 24) + Hours + (Minutes > 30 ? 1 : 0);

            TotalPrice = TotalHours * PriceMultiplier;
        }
        public int PriceMultiplier { get; set; }
        public int TotalPrice { get; set; }



    }
}
