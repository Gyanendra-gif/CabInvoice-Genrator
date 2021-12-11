using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CabInvoiceGenrator
{
    public class InvoiceGenerator
    {
        readonly private double COSTPERKM = 10.0;
        readonly private double COSTPERMIN = 1.0;
        readonly private double MINFARE = 1.0;
        readonly private double time;
        readonly private double distance;

        public double CalculateFare(double distance, double time) 
        {
            double totalFare = (distance * COSTPERKM) + (time * COSTPERMIN);
            if (totalFare < MINFARE)
            {
                return MINFARE;
            }
            return totalFare;
        }
        public double CalculateMultipleRideFare(MultipleRide[] multipleRide) 
        {
            double totalFare = 0;
            foreach (var data in multipleRide)
            {
                totalFare += this.CalculateFare(data.distance, data.time);
            }
            return totalFare;
        }
        public InvoiceSummery CalculateInvoiceSummery(MultipleRide[] multipleRide)
        {
            double totalFare = this.CalculateMultipleRideFare(multipleRide);
            InvoiceSummery summery = new InvoiceSummery();
            summery.totalFare = totalFare;
            summery.totalNumberOfRides = multipleRide.Count();
            summery.CalulateAverageFare();
            return summery;

        }
    }
}
