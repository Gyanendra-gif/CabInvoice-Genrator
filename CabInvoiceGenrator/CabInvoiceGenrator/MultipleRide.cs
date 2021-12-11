using System;
using System.Collections.Generic;
using System.Text;

namespace CabInvoiceGenrator
{
    public class MultipleRide
    {
        readonly public double distance;
        readonly public double time;

        public MultipleRide(double CoveredDistance, double CoveredTime) 
        {
            this.distance = CoveredDistance;
            this.time = CoveredTime;
        }
    }
}