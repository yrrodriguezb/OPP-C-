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
            var success = true;

            if (product.HasChanges)
            {
                if (product.IsValid)
                {
                    if (product.IsNew)
                    {
                        // Call an insert stored prodecure
                    }
                    else
                    {
                        // Call an update stored prodecure
                    }
                }
                else
                {
                    success = false;
                }
            }

            return success;
        }
    }
}