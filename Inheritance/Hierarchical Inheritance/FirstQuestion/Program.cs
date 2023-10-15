using System;

namespace FirstQuestion;

class Program
{
    public static void Main(string[] args)
    {
        StudentInfo student = new StudentInfo("Ashik", "Varghese", 9080505109, "ashikvarghese@gmail.com", DateTime.ParseExact("14/06/2002", "dd/MM/yyyy", null), "Male", "SID1001", "BE", "CSE", "6");
        student.ShowDetails();

        Teacher teacher = new Teacher("Revathi", "Suresh", 9080505109, "revathi@gmail.com", DateTime.ParseExact("14/06/1989", "dd/MM/yyyy", null), "Female", "TID2001", "ECE", "PHYSICS", "BE", 5, DateTime.ParseExact("14/06/2002", "dd/MM/yyyy", null));
        ShowDetails(teacher);

        PrincipleInfo principle = new PrincipleInfo("Ruby", "Maani", 9080505109, "kesavan@gmail.com", DateTime.ParseExact("14/06/1989", "dd/MM/yyyy", null), "Female", "PID201", "BE", 4, DateTime.ParseExact("14/06/2002", "dd/MM/yyyy", null));
        ShowPrincipleetails(principle);
    }

    public static void ShowDetails(Teacher teacher)
    {
        System.Console.WriteLine($"Teacher Name : {teacher.Name}\nDepartment : {teacher.Department}\nTeacher ID : {teacher.TeacherID}\nDepartment : {teacher.Department}\nSubject Teaching : {teacher.SubjectTeaching}\nQualification : {teacher.Qualification}\nYears Of Experience : {teacher.YearOfExperience}\nDate of Joining : {teacher.DateOfJoining}");
    }

    public static void ShowPrincipleetails(PrincipleInfo principle)
    {
        System.Console.WriteLine($"Principle Name : {principle.Name}\nPrincipal ID : {principle.PrincipalID}\nQualification : {principle.Qualification}\nYears Of Experience : {principle.YearOfExperience}\nDate of Joining : {principle.DateOfJoining}");
    }
}