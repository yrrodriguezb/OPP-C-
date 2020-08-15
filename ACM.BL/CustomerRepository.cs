using System;
using System.Linq;

namespace ACM.BL
{
    public class CustomerRepository
    {
        private AddressRepository addressRepository { get; set; }

        public CustomerRepository()
        {
            addressRepository = new AddressRepository();
        }

        /// <summary>Retrieve one customer</summary>
        public Customer Retrieve(int customerId)
        {
            Customer customer = new Customer(customerId);

            if (customerId == 1)
            {
                customer.EmailAddress = "Alan@gmail.com";
                customer.FirstName = "Alan";
                customer.LastName = "Baggins";
                customer.AddressList =
                    addressRepository
                    .RetrieveByCustomerId(customerId)
                    .ToList();

            }

            return customer;
        }

        /// <summary>Save the current customer</summary>
        public bool Save(Customer customer)
        {
            // Code that saves the passed in customer

            return true;
        }
    }
}