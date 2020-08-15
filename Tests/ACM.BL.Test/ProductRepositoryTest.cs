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
    }
}
