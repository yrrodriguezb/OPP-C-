using Microsoft.VisualStudio.TestTools.UnitTesting;
using ACM.BL;

namespace ACM.BL.Test
{
    [TestClass]
    public class ProductRepositoryTest
    {
        [TestMethod]
        public void RetrieveDisplayProductTest()
        {
            // Arrange
            var productRepository = new ProductRepository();
            var expected = new Product(2)
            {
                ProductName = "Sunflowers",
                ProductDescripcion = "Some Description",
                CurrentPrice = 15.95M
            };

            // Act
            var actual = productRepository.Retrieve(2);

            // Assert
            Assert.AreEqual(expected.CurrentPrice, actual.CurrentPrice);
            Assert.AreEqual(expected.ProductDescripcion, actual.ProductDescripcion);
            Assert.AreEqual(expected.ProductName, actual.ProductName);
        }

        [TestMethod]
        public void SaveTestValid()
        {
            // Arrange
            var productRepository = new ProductRepository();
            var updateProduct = new Product(2)
            {
                ProductName = "Sunflowers",
                ProductDescripcion = "Some Description Modified",
                CurrentPrice = 19M,
                HasChanges = true
            };
            var expected = true;

            // Act
            var actual = productRepository.Save(updateProduct);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SaveTestMissingPrice()
        {
            // Arrange
            var productRepository = new ProductRepository();
            var updateProduct = new Product(2)
            {
                ProductName = "Sunflowers",
                ProductDescripcion = "Some Description Modified",
                CurrentPrice = null,
                HasChanges = true
            };
            var expected = false;

            // Act
            var actual = productRepository.Save(updateProduct);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
