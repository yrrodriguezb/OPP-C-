using System;
using System.Collections.Generic;
using Acme.Common;

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

        private string _productName;
        public string ProductName 
        { 
            get
            {
                return _productName.InsertSpaces();
            } 
            set
            {
                _productName = value;
            }
        }

            


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
