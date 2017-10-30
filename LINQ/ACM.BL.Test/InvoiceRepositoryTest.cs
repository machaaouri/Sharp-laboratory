using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACM.BL.Test
{
    [TestClass]
    public class InvoiceRepositoryTest
    {
        public TestContext TestContext { get; set; }

        [TestMethod]
        public void CalculateTotalAmountInvoicedTest()
        {
            // Arrange
            InvoiceRepository repository = new InvoiceRepository();
            var invoiceList = repository.Retrieve();

            // Act
            var actual = repository.CalculateTotalAmountInvoiced(invoiceList);

            // Assert
            Assert.AreEqual(1333.14M, actual);
        }


        [TestMethod]
        public void CalculateTotalUnitsSoldTest()
        {
            // Arrange
            InvoiceRepository repository = new InvoiceRepository();
            var invoiceList = repository.Retrieve();

            // Act
            var actual = repository.CalculateTotalUnitsSold(invoiceList);

            // Assert
            Assert.AreEqual(136, actual);
        }

        [TestMethod]
        public void GetInvoiceTotalByIsPaidTest()
        {
            // Arrange
            InvoiceRepository repository = new InvoiceRepository();
            var invoiceList = repository.Retrieve();

            // Act
            var query = repository.GetInvoiceTotalByIsPaid(invoiceList);

            // NOT REALLY A TEST
        }

        [TestMethod]
        public void GetInvoiceTotalByIsPaidAndMonthTest()
        {
            // Arrange
            InvoiceRepository repository = new InvoiceRepository();
            var invoiceList = repository.Retrieve();

            // Act
            var query = repository.GetInvoiceTotalByIsPaidAndMonth(invoiceList);

            // NOT REALLY A TEST
        }
    }
}