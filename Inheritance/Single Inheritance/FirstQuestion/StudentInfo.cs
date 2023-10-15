using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstQuestion
{
    public class StudentInfo : PersonalInfo
    {
        public string RegisterNumber { get; set; }
        public string Standard { get; set; }
        private string _branch;
        public string Branch { get; }
        public int Year { get; set; }
        public StudentInfo(){
            Branch = "CSE";
        }
        public StudentInfo(string name, string fatherName, long phoneNumber, string email, DateTime date, string gender, string registerNumber, string standard, string branch, int year) : base(name,fatherName,phoneNumber,email,date,gender){
            RegisterNumber = registerNumber;
            Standard = standard;
            Branch = branch;
            Year = year;
        }

        public void ShowStudentInfo(){
            System.Console.WriteLine($"Name : {Name}\nFather Name : {FatherName}\nPhone Number : {PhoneNumber}\nEmail : {Email}\nDate of Birth : {Date.ToString("dd/MM/yyyy")}\nGender : {Gender}\nRegister Number : {RegisterNumber}\nStandard : {Standard}\nBranch : {Branch}\nYear : {Year}");
        }
        
    }
}