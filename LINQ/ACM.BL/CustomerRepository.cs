﻿using System.Collections.Generic;
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

        public List<Customer> Retrieve()
        {
            List<Customer> custList = new List<Customer>
                    {new Customer()
                          { CustomerId = 1,
                            FirstName="Frodo",
                            LastName = "Baggins",
                            EmailAddress = "fb@hob.me",
                            CustomerTypeId=1},
                    new Customer()
                          { CustomerId = 2,
                            FirstName="Bilbo",
                            LastName = "Baggins",
                            EmailAddress = "bb@hob.me",
                            CustomerTypeId=null},
                    new Customer()
                          { CustomerId = 3,
                            FirstName="Samwise",
                            LastName = "Gamgee",
                            EmailAddress = "sg@hob.me",
                            CustomerTypeId=1},
                    new Customer()
                          { CustomerId = 4,
                            FirstName="Rosie",
                            LastName = "Cotton",
                            EmailAddress = "rc@hob.me",
                            CustomerTypeId=2}};
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
