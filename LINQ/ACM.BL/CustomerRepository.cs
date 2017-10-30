using System;
using System.Collections.Generic;
using System.Linq;
namespace ACM.BL
{
    public class CustomerRepository
    {
        public Customer Find(List<Customer> customerList, int customerId)
        {
            Customer foundCustomer = null;

            //foreach (var c in customerList)
            //{
            //    if (c.CustomerId == customerId)
            //    {
            //        foundCustomer = c;
            //        break;
            //    }
            //}

            //Query syntax
            //var query = from c in customerList
            //            where c.CustomerId == customerId
            //            select c;

            //foundCustomer = query.First();




            // First throws an exception if no value match the criteria ( use first or default instead)
            // Default value for most reference types is NULL

            foundCustomer = customerList.FirstOrDefault(c =>
                                c.CustomerId == customerId);


            //Lambda expression in multiple lines
            //foundCustomer = customerList.FirstOrDefault(c =>
            //                        {
            //                            Debug.WriteLine(c.LastName);
            //                            return c.CustomerId == customerId;
            //                        });

            //foundCustomer = customerList.Where(c =>
            //                    c.CustomerId == customerId)
            //                    .Skip(1)
            //                    .FirstOrDefault();



            return foundCustomer;

        }


        public IEnumerable<string> GetNames(List<Customer> customerList)
        {
            var query = customerList.Select(c => c.LastName + ", " + c.FirstName);

            return query;
        }

        public dynamic GetNamesAndEmail(List<Customer> customerList)
        {
            var query = customerList.Select(c => new
                            {Name = c.LastName + ", " + c.FirstName,
                             c.EmailAddress
                            });
            foreach(var item in query)
            {
                Console.WriteLine(item.Name + " :" + item.EmailAddress);
            }

            return query;
        }


        public dynamic GetNamesAndType(List<Customer> customerList,
                                           List<CustomerType> customerTypeList)
        {
            var query = customerList.Join(customerTypeList,
                            outer => outer.CustomerTypeId,
                            inner => inner.CustomerTypeId,
                            (outer, inner) => new
                            {
                                Name = outer.LastName + ", " + outer.FirstName,
                                CustomerTypeName = inner.TypeName
                            });

            foreach (var item in query)
            {
                Console.WriteLine(item.Name + ": " + item.CustomerTypeName);
            }

            return query;
        }

        public IEnumerable<Customer> GetOverDueCustomers(List<Customer> customerList)
        {

            var query = customerList.SelectMany(c => c.InvoiceList
                                                 .Where(i => (i.IsPaid ?? false) == false),
                                                 (c,i)=> c).Distinct();

            return query;
        }


        public IEnumerable<KeyValuePair<string,decimal>> GetInvoiceTotalByCustomerType(List<Customer> customerList,
                                                    List<CustomerType> customerTypeList)
        {

            var customerTypequery = customerList.Join(customerTypeList,
                                    c=> c.CustomerTypeId,
                                    ct=> ct.CustomerTypeId,
                                    (c,ct)=> new
                                    {
                                        CustomerInstance = c,
                                        customerTypeName = ct.TypeName
                                    });

            var query = customerTypequery.GroupBy(c => c.customerTypeName,
                                             c => c.CustomerInstance.InvoiceList.Sum(inv => inv.TotalAmount),
                                             (groupKey, invTotal) => new KeyValuePair<string,decimal>(groupKey,invTotal.Sum()));
            foreach (var item in query)
            {
                Console.WriteLine(item.Key + ": " + item.Value);
            }

            return query;
        }


        public List<Customer> Retrieve()
        {
            InvoiceRepository invoiceRepository = new InvoiceRepository();

            List<Customer> custList = new List<Customer>
                    {new Customer()
                          { CustomerId = 1,
                            FirstName="Frodo",
                            LastName = "Baggins",
                            EmailAddress = "fb@hob.me",
                            CustomerTypeId=1,
                            InvoiceList=invoiceRepository.Retrieve(1)},
                    new Customer()
                          { CustomerId = 2,
                            FirstName="Bilbo",
                            LastName = "Baggins",
                            EmailAddress = "bb@hob.me",
                            CustomerTypeId=null,
                            InvoiceList=invoiceRepository.Retrieve(2)},
                    new Customer()
                          { CustomerId = 3,
                            FirstName="Samwise",
                            LastName = "Gamgee",
                            EmailAddress = "sg@hob.me",
                            CustomerTypeId=4,
                            InvoiceList=invoiceRepository.Retrieve(3)},
                    new Customer()
                          { CustomerId = 4,
                            FirstName="Rosie",
                            LastName = "Cotton",
                            EmailAddress = "rc@hob.me",
                            CustomerTypeId = 2,
                            InvoiceList = invoiceRepository.Retrieve(4)}};
            return custList;
        }

        public IEnumerable<Customer> RetrieveEmptyList()
        {
            return Enumerable.Repeat(new Customer(), 10);
        }

        public IEnumerable<Customer> SortByName(List<Customer> customerList)
        {
            // make use of chaining, we are chaining together the OrderBy and the ThenBy
            return customerList.OrderBy(c => c.LastName)
                            .ThenBy(c => c.FirstName);
        }

        public IEnumerable<Customer> SortByNameInReverse(List<Customer> customerList)
        {
            //return customerList.OrderByDescending(c => c.LastName)
            //                .ThenByDescending(c => c.FirstName);

            return SortByName(customerList).Reverse();
        }

        public IEnumerable<Customer> SortBytpe(List<Customer> customerList)
        {
            return customerList.OrderByDescending(c => c.CustomerTypeId.HasValue)
                                .ThenBy(c => c.CustomerTypeId);
        }
    }
}
