using Microsoft.VisualStudio.TestTools.UnitTesting;
using ACM.BL;

namespace ACM.BL.Test
{
    [TestClass]
    public class CustomerRepositoryTest
    {
        [TestMethod]
        public void RetrieveDisplayCustomerValid()
        {
            // Arrange
            var customerRepository = new CustomerRepository();
            var expected = new Customer(1)
            {
                EmailAddress = "abc@gmail.com",
                FirstName = "Frodo",
                LastName = "Bagginns"
            };

            // Act
            var actual = customerRepository.Retrieve(1);

            // Assert
            Assert.AreEqual(expected.CustomerId, actual.CustomerId);
        }
    }
}
