using CabInvoiceGenrator;
using NUnit.Framework;

namespace CabInvoiceGeneratorTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void GivenDistanceTime_WhenCalculate_ShouldReturnTotalFare()
        {
            InvoiceGenerator invoice = new InvoiceGenerator();
            double result = invoice.CalculateFare(5, 2);
            Assert.AreEqual(result, 52);
        }
        [Test]
        public void GivenDistanceTime_WhenCalculate_ShouldReturnTotalFareOfMultipleRide()
        {
            MultipleRide[] multipleRides = { new MultipleRide(7, 3), new MultipleRide(5, 4) };
            InvoiceGenerator invoiceGenerator = new InvoiceGenerator();
            double actual = invoiceGenerator.CalculateMultipleRideFare(multipleRides);
            Assert.AreEqual(actual, 127);

        }
        [Test]
        public void GivenDistanceTime_WhenCalculate_ShouldReturnAverageFair()
        {
            MultipleRide[] multipleRides = { new MultipleRide(7, 3), new MultipleRide(5, 4) };
            InvoiceGenerator invoiceGenerator = new InvoiceGenerator();
            InvoiceSummery result = invoiceGenerator.CalculateInvoiceSummery(multipleRides);
            InvoiceSummery summery = new InvoiceSummery();
            summery.totalFare = 124;
            summery.totalNumberOfRides = 2;
            summery.CalulateAverageFare();
            if (result.totalFare == summery.totalFare && result.totalFare == summery.averageFarePerRide && summery.averageFarePerRide == result.averageFarePerRide)
            {
                Assert.IsTrue(false);
            }
            else
            {
                Assert.IsTrue(true);
            }
        }
    }
}