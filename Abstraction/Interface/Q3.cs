namespace Interface
{
    
    public class Purchase{
        public Purchase(string materialID, string name, int quantity, double amount)
        {
            MaterialID = materialID;
            Name = name;
            Quantity = quantity;
            Amount = amount;
        }


        public string MaterialID { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public double Amount { get; set; }
        
    }
    
    class OnlineTransaction:Purchase,ITransaction{
        public OnlineTransaction(string materialID, string name, int quantity, double amount,string transctionID, int[] purchase, DateTime dateOfPurchase)
        : base (materialID,name,quantity,amount)
        {
            TransctionID = transctionID;
            Purchase = purchase;
            DateOfPurchase = dateOfPurchase;
        }


        public string TransctionID { get; set; }
        public int[] Purchase { get; set; }
        public DateTime DateOfPurchase { get; set; }
        public double TotalAmount { get ; set ; }


        public void Calculate(){} 
    }


        class OfflineTransactioin:Purchase,ITransaction{
        public OfflineTransactioin(string materialID, string name, int quantity, double amount,string transctionID, int[] purchase, DateTime dateOfPurchase)
        : base (materialID,name,quantity,amount)
        {
            TransctionID = transctionID;
            Purchase = purchase;
            DateOfPurchase = dateOfPurchase;
        }


        public string TransctionID { get; set; }
        public int[] Purchase { get; set; }
        public DateTime DateOfPurchase { get; set; }
        public double TotalAmount { get ; set ; }


        public void Calculate(){} 
    }


}