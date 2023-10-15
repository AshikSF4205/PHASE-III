using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstQuestion
{
    public class Teacher : PersonalInfo
    {
        // Properties: TeacherID, Department, Subject teaching, Qualification, YearOfExperience, DateOfJoining
        //  Methods:  ShowDetails
        public string TeacherID { get; set; }
        public string Department { get; set; }
        public string SubjectTeaching { get; set; }
        public string Qualification { get; set; }
        public int YearOfExperience { get; set; }
        public DateTime DateOfJoining { get; set; }
        public Teacher(string name, string fatherName, long phoneNumber, string email, DateTime date, string gender, string teacherId, string department, string Subject, string qualification, int yearsofExp, DateTime dateOfJoin) : base(name, fatherName, phoneNumber, email, date, gender)
        {
            TeacherID = teacherId;
            Department = department;
            SubjectTeaching = Subject;
            Qualification = qualification;
            YearOfExperience = yearsofExp;
            DateOfJoining = dateOfJoin;
        }

        // public void ShowDetails(){
        //     System.Console.WriteLine($"Teacher Name : {Name}\nDepartment : {Department}\nTeacher ID : {TeacherID}\nDepartment : {Department}\nSubject Teaching : {SubjectTeaching}\nQualification : {Qualification}\nYears Of Experience : {YearOfExperience}\nDate of Joining : {DateOfJoining}");
        // }




    }
}