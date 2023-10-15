using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineGroceryStore
{
    public class OrderDetails
    {
        // Properties: OrderID, BookingID, ProductID, PurchaseCount, PriceOfOrder

        private static int s_id = 100;
        private string _orderID;

        public string OrderID
        {
            get
            {
                return _orderID;
            }
        }
        public string BookingID { get; set; }
        public string ProductID { get; set; }
        public int PurchaseCount { get; set; }
        public double PriceOfOrder { get; set; }

        public OrderDetails(string bookingID, string productID, int purchaseCount, double priceOfOrder)
        {
            _orderID = $"OID{++s_id}";
            BookingID = bookingID;
            ProductID = productID;
            PurchaseCount = purchaseCount;
            PriceOfOrder = priceOfOrder;
        }
    }
}