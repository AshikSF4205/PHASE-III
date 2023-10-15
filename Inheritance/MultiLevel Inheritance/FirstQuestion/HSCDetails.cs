using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstQuestion
{
    public class HSCDetails : StudentInfo
    {
        public string HSCMarksheetNumber { get; set; }
        public int Physics { get; set; }
        public int Chemistry { get; set; }
        public int Maths { get; set; }
        public int Total { get; set; }
        public double Percentage { get; set; }
        public HSCDetails(string name, string fatherName, long phoneNumber, string email, DateTime date, string gender, string registerNumber, string standard, string branch, int year,string hSCMarksheetNumber,int physics,int chemistry,int maths) : base(name, fatherName, phoneNumber, email, date, gender, registerNumber, standard, branch, year)
        {
            HSCMarksheetNumber = hSCMarksheetNumber;
            Physics = physics;
            Chemistry = chemistry;
            Maths = maths;
        }

        public void GetMarks(){
            System.Console.WriteLine($"Physics : {Physics}\nChemistry : {Chemistry}\nMaths : {Maths}");
        }

        public void TotalMarks(){
            Total = Physics + Chemistry + Maths;
            System.Console.WriteLine($"Total Marks : {Total}");
        }

        public void Percentagee(){
            Percentage = (Total*100/300);
            System.Console.WriteLine($"Percentage : {Percentage}");
        }

        public void ShowMarkSheet(){
            System.Console.WriteLine($"Name : {Name}\nDate of Birth : {Date}\nGender : {Gender}\nPhyscis : {Physics}\nChemistry : {Chemistry}\nMaths : {Maths}\nTotal : {Total}");
        }
    }
}