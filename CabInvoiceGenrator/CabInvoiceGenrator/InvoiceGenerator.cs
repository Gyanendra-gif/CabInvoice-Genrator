using System;
using System.Collections.Generic;
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

        public InvoiceGenerator (double runningDistance, double runningTime) 
        {
            this.distance = runningDistance;
            this.time = runningTime;
        }
        public double CalculateFare() 
        {
            double totalFare = (distance * COSTPERKM) + (time * COSTPERMIN);
            if (totalFare < MINFARE)
            {
                return MINFARE;
            }
            return totalFare;
        }

    }
}
