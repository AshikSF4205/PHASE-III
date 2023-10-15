using Hybrid;

namespace Hybrid1
{
    public enum Gender{Male,Female};
    public class Q2
    {
        
    }

     class PersonalInfo{
        public PersonalInfo(string name, string fatherName, long phone, string mail, DateTime doB, Gender gender)
        {
            Name = name;
            FatherName = fatherName;
            Phone = phone;
            Mail = mail;
            DoB = doB;
            this.gender = gender;
        }


        public string Name  { get; set; }
        public string FatherName { get; set; }
        public long  Phone { get; set; }
        public string Mail { get; set; }
        public DateTime DoB { get; set; }
        public Gender gender { get; set; }                
    }

    class IDInfo : PersonalInfo{
        public IDInfo(string name, string fatherName, long phone, string mail, DateTime doB, Gender gender,string voterID, string aadharID, string pANnumber)
        : base (name,fatherName,phone,mail,doB,gender)
        {
            VoterID = voterID;
            AadharID = aadharID;
            PANnumber = pANnumber;
        }

        // VoterID, AadharID, PAN number


        public string VoterID { get; set; }
        public string AadharID { get; set; }
        public string PANnumber { get; set; }
    }
    class SavingsAccount : IDInfo, ICalculate1, IBankInfo
    {
        public SavingsAccount(string name, string fatherName, long phone, string mail, DateTime doB, Gender gender,string voterID, string aadharID, string pANnumber,long accountNumber, string accountType, double balance, string bankName, long iFSCcode, string branch)
        :base(name,fatherName,phone,mail,doB,gender,voterID,aadharID,pANnumber)
        {
            AccountNumber = accountNumber;
            AccountType = accountType;
            Balance = balance;
            BankName = bankName;
            IFSCcode = iFSCcode;
            Branch = branch;
        }


        public  long AccountNumber { get; set; }
        public string AccountType { get; set; }
        public double Balance { get; set; }
        public string BankName { get  ; set  ; }
        public long IFSCcode { get  ; set  ; }
        public string Branch { get  ; set  ; }


        public void BalanceCheck()
        {
            System.Console.WriteLine("Your Balance is "+ Balance);;
        }

        public void Deposit(double amount)
        {
            Balance+=amount;
        }

        public void WithDraw(double amount)
        {
            Balance-=amount;
        }
    }

}