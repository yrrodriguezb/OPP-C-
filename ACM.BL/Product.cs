using System;
using System.Collections.Generic;

namespace ACM.BL
{
    public class Product : EntityBase
    {
        public Product()
        {
        }

        public Product(int productId)
        {
            ProductId = productId;
        }

        public decimal? CurrentPrice { get; set; }
        public string ProductDescripcion { get; set; }
        public int ProductId { get; private set; }
        public string ProductName { get; set; }


        public override string ToString() => ProductName;

        /// <summary>Validates the product data</summary>
        /// <returns></returns>
        public override bool Validate()
        {
            var isValid = true;

            if (IsNullOrWhiteSpace(ProductName) || IsNull(CurrentPrice))
                isValid = false;

            return isValid;
        }

        private bool IsNullOrWhiteSpace(string value)
        {
            return string.IsNullOrWhiteSpace(value);
        }

        private bool IsNull(decimal? price)
        {
            return price == null;
        }
    }
}
