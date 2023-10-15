namespace Interface
{
    public interface ITransaction
    {
            public double TotalAmount { get; set; }
            public void Calculate(double amount){}
            public void DisplayBill(){}
            

    }
}