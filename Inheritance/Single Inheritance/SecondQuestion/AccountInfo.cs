using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.Marshalling;
using System.Threading.Tasks;

namespace SecondQuestion
{
    public class AccountInfo : PersonalInfo
    {   

    public long AccountNumber { get; set; }
      public string BranchName { get; set; }  
      public string IfscCode { get; set; }
      public double Balance { get; set; }

      public AccountInfo(string name, string fatherName, long phoneNumber, string email, DateTime date, string gender,long accountNumber,string branchName,string ifsc,double balance) : base(name, fatherName, phoneNumber, email, date, gender)
        {
            AccountNumber = accountNumber;
            BranchName = branchName;
            IfscCode = ifsc;
            Balance = balance;
        }

        public void ShowAccountInfo(){
            System.Console.WriteLine($"Account Number : {AccountNumber}\nBranch Name : {BranchName}\nIFSC CODE :{IfscCode}\nBalance : {Balance}");
        }

        public void Deposit(double amount){
            Balance += amount;
        }

        public void Withdraw(double amount){
            Balance -= amount;
        }

        public void ShowBalance(){
            System.Console.WriteLine($"Current Balance : {Balance}");
        }
    }
}