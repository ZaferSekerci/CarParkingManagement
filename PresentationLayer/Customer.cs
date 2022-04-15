using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresentationLayer
{
    class Customer
    {
        public DateTime EntryTime { get; set; }
        public DateTime ExitTime { get; set; }
        public Car Car { get; set; }
    }
}
