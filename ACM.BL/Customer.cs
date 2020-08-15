using System;
using System.Collections.Generic;

namespace ACM.BL
{
    public class Customer
    {

        public Customer()
        {
        }

        public Customer(int customerId)
        {
            CustomerId = customerId;
        }



        // Propiedad que esta en la clase pero no pertenece al objeto en si, ya que tiene el modificador estático
        public static int InstanceCount { get; set; }
        public int CustomerId { get; private set; }
        public string EmailAddress { get; set; }
        public string FirstName { get; set; }
        public string FullName
        {
            get
            {
                string fullName = FullName;

                if (!string.IsNullOrWhiteSpace(FirstName))
                {
                    if (!string.IsNullOrWhiteSpace(FullName))
                    {
                        fullName += ", ";
                    }

                    fullName += FirstName;
                }

                return fullName;
            }
        }
        private string _lastName;
        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }

        /// <summary>Retrieve one customer</summary>
        public Customer Retrieve(int customerId)
        {
            return new Customer();
        }

        /// <summary>Retrieve all customers</summary>
        public List<Customer> Retrieve()
        {
            return new List<Customer>();
        }

        /// <summary>Save the current customer</summary>
        public bool Save()
        {
            return true;
        }

        /// <summary>Validates the customer data</summary>
        /// <returns></returns>
        public bool Validate()
        {
            var isValid = true;

            if (IsNullOrWhiteSpace(LastName) || IsNullOrWhiteSpace(EmailAddress))
                isValid = false;

            return isValid;
        }

        private bool IsNullOrWhiteSpace(string value)
        {
            return string.IsNullOrWhiteSpace(value);
        }
    }
}
