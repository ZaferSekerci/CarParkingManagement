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
            int TotalHours = ((int)SpentTime.TotalDays * 24) + ((int)SpentTime.TotalHours) + ((int)SpentTime.TotalSeconds > 30 ? 1 : 0);
            TotalPrice = TotalHours.ToString();
        }
        public int PriceMultiplier { get; set; }
        public string TotalPrice { get; set; }

        //public decimal CalculateBill(DateTime exitTime)
        //{
        //    DateTime totalTime;
        //    totalTime = exitTime - DateTime.Now;

        //}

    }
}
