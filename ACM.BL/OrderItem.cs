using System;
using System.Collections.Generic;

namespace ACM.BL
{
    public class OrderItem
    {
        public OrderItem()
        {
        }

        public OrderItem(int orderItemId)
        {
            OrderItemId = orderItemId;
        }

        public int OrderItemId { get; private set; }
        public int ProductId { get; set; }
        public decimal? PurcharsePrice { get; set; }
        public int Quantity { get; set; }

        /// <summary>Retrieve one order item</summary>
        public OrderItem Retrieve(int customerId)
        {
            return new OrderItem();
        }

        /// <summary>Retrieve all orders</summary>
        public List<OrderItem> Retrieve()
        {
            return new List<OrderItem>();
        }

        /// <summary>Save the order customer</summary>
        public bool Save()
        {
            return true;
        }

        /// <summary>Validates the order data</summary>
        /// <returns></returns>
        public bool Validate()
        {
            var isValid = true;

            if (IsNumberNegativeOrZero(Quantity) || IsNumberNegativeOrZero(ProductId) || IsNull(PurcharsePrice))
                isValid = false;

            return isValid;
        }

        private bool IsNullOrWhiteSpace(string value)
        {
            return string.IsNullOrWhiteSpace(value);
        }

        private bool IsNull(decimal? date)
        {
            return date == null;
        }

        private bool IsNumberNegativeOrZero(int number)
        {
            return number <= 0;
        }
    }
}
