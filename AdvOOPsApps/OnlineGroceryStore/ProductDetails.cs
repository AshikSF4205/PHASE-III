using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineGroceryStore
{
    public class ProductDetails
    {
        private static int s_id = 100;
        private string _productID;
        
        public string ProductID
        {
            get
            {
                return _productID;
            }
        }
        public string ProductName { get; set; }
        public int QuantityAvailable { get; set; }
        public double PricePerQuantity { get; set; }

        public ProductDetails(string productName, int quantityAvailable, double pricePerQuantity)
        {
            _productID = $"PID{++s_id}";
            ProductName = productName;
            QuantityAvailable = quantityAvailable;
            PricePerQuantity = pricePerQuantity;
        }
    }
}