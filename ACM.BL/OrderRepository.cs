using System;

namespace ACM.BL
{
    public class OrderRepository
    {

        /// <summary>Retrieve one order</summary>
        public Order Retrieve(int orderId)
        {
            Order order = new Order(orderId);

            if (orderId == 10)
            {
                order.OrderDate = new DateTimeOffset(DateTime.Now.Year, 4, 14, 10, 00, 00, new TimeSpan(7, 0, 0));
            }

            return order;
        }

        /// <summary>Save the current order</summary>
        public bool Save(Order order)
        {
            // Code that saves the passed in order

            return true;
        }
    }
}