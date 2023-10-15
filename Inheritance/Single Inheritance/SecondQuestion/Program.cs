using System;

namespace SecondQuestion;

class Program{
    public static void Main(string[] args)
    {
        AccountInfo account = new AccountInfo("Ashik","Varghese",9080505109,"ashik@gmail.com",DateTime.ParseExact("14/06/2002","dd/MM/yyyy",null),"Male",54637889,"Anna Nagar","IFSC0987",5000);
        account.ShowAccountInfo();
        account.Deposit(500);
        account.Withdraw(200);
        account.ShowBalance();

        AccountInfo account2 = new AccountInfo("Karthik","Murugan",9080505109,"karthik@gmail.com",DateTime.ParseExact("12/07/2006","dd/MM/yyyy",null),"Male",54637890,"Anna Nagar","IFSC0987",5000);
        account2.ShowAccountInfo();
        account2.Deposit(500);
        account2.Withdraw(200);
        account2.ShowBalance();

        AccountInfo account3 = new AccountInfo("Vishnu","Prakash",9080505109,"vishnu@gmail.com",DateTime.ParseExact("12/07/1979","dd/MM/yyyy",null),"Male",54637891,"Anna Nagar","IFSC0987",5000);
        account3.ShowAccountInfo();
        account3.Deposit(500);
        account3.Withdraw(200);
        account3.ShowBalance();
    }
}