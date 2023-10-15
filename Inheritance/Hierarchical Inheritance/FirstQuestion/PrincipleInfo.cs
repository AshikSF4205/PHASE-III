using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstQuestion
{
    public class PrincipleInfo : PersonalInfo
    {
        //         Properties: PrincipalID, Qualification, YearOfExperience, DateOfJoining
        // Methods: ShowDetails

        public string PrincipalID { get; set; }
        public string Qualification { get; set; }
        public int YearOfExperience { get; set; }
        public DateTime DateOfJoining { get; set; }
        public PrincipleInfo(string name, string fatherName, long phoneNumber, string email, DateTime date, string gender,string principalID,string qualification,int yearOfExperience,DateTime dateOfJoining) : base(name, fatherName, phoneNumber, email, date, gender)
        {
            PrincipalID = principalID;
            Qualification = qualification;
            YearOfExperience = yearOfExperience;
            DateOfJoining = dateOfJoining;
        }

        // public void ShowDetails(){
        //     System.Console.WriteLine($"Principle Name : {Name}\nPrincipal ID : {PrincipalID}\nQualification : {Qualification}\nYears Of Experience : {YearOfExperience}\nDate of Joining : {DateOfJoining}");
        // }
    }
}