using System;
using System.Collections.Generic;
using System.Text;

namespace CabInvoiceGenrator
{
   public class InvoiceSummery
    {
        public int totalNumberOfRides { get; set; }
        public double totalFare { get; set; }
        public double averageFarePerRide { get; set; }
        public void CalulateAverageFare()
        {
            averageFarePerRide = totalFare / totalNumberOfRides;
        }
    }
}
