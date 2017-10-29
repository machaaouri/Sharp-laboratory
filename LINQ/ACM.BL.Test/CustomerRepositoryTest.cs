using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACM.BL.Test
{
    [TestClass]
    public class CustomerRepositoryTest
    {
        [TestMethod]
        public void FindExistingCustomer()
        {
            CustomerRepository repository = new CustomerRepository();

            var customerList = repository.Retrieve();

            var result = repository.Find(customerList, 2);

            Assert.IsNotNull(result);
            Assert.AreEqual(2, result.CustomerId);
            Assert.AreEqual("Baggins", result.LastName);
            Assert.AreEqual("Bilbo", result.FirstName);
        }

        [TestMethod]
        public void FindTestNotFound()
        {
            CustomerRepository repository = new CustomerRepository();

            var customerList = repository.Retrieve();

            var result = repository.Find(customerList, 50);

            Assert.IsNull(result);
        }
    }
}
