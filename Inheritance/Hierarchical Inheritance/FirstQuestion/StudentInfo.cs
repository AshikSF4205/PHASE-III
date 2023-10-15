using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstQuestion
{
    public class StudentInfo : PersonalInfo
    {
        //         Properties: StudentID, Degree, Department, semester 
        // Methods: ShowDetails
        public string StudentID { get; set; }
        public string Degree { get; set; }
        public string Department { get; set; }
        public string Semester { get; set; }
        public StudentInfo(string name, string fatherName, long phoneNumber, string email, DateTime date, string gender,string studentID,string degree,string department,string semester) : base(name, fatherName, phoneNumber, email, date, gender)
        {
            StudentID = studentID;
            Degree = degree;
            Department = department;
            Semester = semester;
        }

        public void ShowDetails(){
            System.Console.WriteLine($"Student Name : {Name}\nDepartment : {Department}\nStudent ID : {StudentID}\nDepartment : {Department}\nDegree : {Degree}\nSemester : {Semester}");
        }
    }
}