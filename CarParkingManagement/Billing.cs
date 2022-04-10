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
            TimeSpan TotalHourSpent = customer.ExitTime - customer.EntryTime;
            TotalPrice = TotalHourSpent.Minutes * PriceMultiplier;
        }
        public int PriceMultiplier { get; set; }
        public decimal TotalPrice { get; set; }

        //public decimal CalculateBill(DateTime exitTime)
        //{
        //    DateTime totalTime;
        //    totalTime = exitTime - DateTime.Now;

        //}

    }
}
