using System;

namespace ACM.BL
{
    public class ProductRepository
    {

        /// <summary>Retrieve one product</summary>
        public Product Retrieve(int productId)
        {
            Product product = new Product(productId);

            if (productId == 2)
            {
                product.ProductName = "Sunflowers";
                product.ProductDescripcion = "Some Description";
                product.CurrentPrice = 15.95M;
            }

            return product;
        }

        /// <summary>Save the current product</summary>
        public bool Save(Product product)
        {
            // Code that saves the passed in product

            return true;
        }
    }
}