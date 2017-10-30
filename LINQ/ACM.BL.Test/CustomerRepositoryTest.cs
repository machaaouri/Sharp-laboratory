using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace ACM.BL.Test
{
    [TestClass]
    public class CustomerRepositoryTest
    {
        public TestContext TestContext { get; set; }

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


        [TestMethod]
        public void GetNamesTest()
        {
            CustomerRepository repository = new CustomerRepository();
            var customerList = repository.Retrieve();

            var query = repository.GetNames(customerList);

            foreach (var item in query)
            {
                TestContext.WriteLine(item);
            }

            Assert.IsNotNull(query);
        }

        [TestMethod]
        public void GetNamesandEmailTest()
        {
            CustomerRepository repository = new CustomerRepository();
            var customerList = repository.Retrieve();

            var query = repository.GetNamesAndEmail(customerList);

            // this is not a test , i only want to see the result
        }

        [TestMethod]
        public void GetNamesandTypelTest()
        {
            CustomerRepository repository = new CustomerRepository();
            var customerList = repository.Retrieve();

            CustomerTypeReposiory typeRepository = new CustomerTypeReposiory();
            var customerTypeList = typeRepository.Retrieve();


            var query = repository.GetNamesAndType(customerList,customerTypeList);

            // this is not a test , i only want to see the result
        }

        [TestMethod]
        public void SortByNameTest()
        {
            CustomerRepository repository = new CustomerRepository();

            var customerList = repository.Retrieve();

            var result = repository.SortByName(customerList);
            Assert.IsNotNull(result);
            Assert.AreEqual(2, result.First().CustomerId);
            Assert.AreEqual("Baggins", result.First().LastName);
            Assert.AreEqual("Bilbo", result.First().FirstName);
        }

        [TestMethod]
        public void SortByNameInReverseTest()
        {
            CustomerRepository repository = new CustomerRepository();

            var customerList = repository.Retrieve();

            var result = repository.SortByNameInReverse(customerList);
            Assert.IsNotNull(result);
            Assert.AreEqual(2, result.Last().CustomerId);
            Assert.AreEqual("Baggins", result.Last().LastName);
            Assert.AreEqual("Bilbo", result.Last().FirstName);
        }

        [TestMethod]
        public void SortByTypeTest()
        {
            CustomerRepository repository = new CustomerRepository();

            var customerList = repository.Retrieve();

            var result = repository.SortBytpe(customerList);
            Assert.IsNotNull(result);
            Assert.AreEqual(null, result.Last().CustomerTypeId);
        }
    }
}
