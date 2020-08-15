using Microsoft.VisualStudio.TestTools.UnitTesting;
using ACM.BL;

namespace ACM.BL.Test
{
    [TestClass]
    public class CustomerTest
    {
        [TestMethod]
        public void FullName_Test_Valid()
        {
            // Arrange
            Customer customer = new Customer();
            customer.FirstName = "Yeison";
            customer.LastName = "Rodriguez";

            string expected = "Rodriguez, Yeison";

            // Act
            string actual = customer.FullName;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FullName_FirstName_Empty()
        {
            // Arrange
            Customer customer = new Customer
            {
                LastName = "Rodriguez"
            };

            string expected = "Rodriguez";

            // Act
            string actual = customer.FullName;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FullName_LastName_Empty()
        {
            // Arrange
            Customer customer = new Customer
            {
                FirstName = "Yeison"
            };

            string expected = "Yeison";

            // Act
            string actual = customer.FullName;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Static_Test()
        {
            // Arrange
            var c1 = new Customer();
            c1.FirstName = "Yeison";
            Customer.InstanceCount += 1;

            var c2 = new Customer();
            c1.FirstName = "Yeison";
            Customer.InstanceCount += 1;

            var c3 = new Customer();
            c1.FirstName = "Yeison";
            Customer.InstanceCount += 1;

            int expected = 3;

            // Act
            int actual = Customer.InstanceCount;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ValidateValid()
        {
            // Arrage
            var customer = new Customer
            {
                LastName = "Yeison",
                EmailAddress = "yeison@gmail.com"
            };

            var expected = true;

            // Act
            var actual = customer.Validate();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ValidateMissingLastName()
        {
            // Arrage
            var customer = new Customer
            {
                EmailAddress = "yeison@gmail.com"
            };

            var expected = false;

            // Act
            var actual = customer.Validate();

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
