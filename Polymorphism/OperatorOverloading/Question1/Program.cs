using System;

namespace Question1;

class Program
{
    public static void Main(string[] args)
    {
        Attendance month1 = new Attendance(20, 2, 3);
        Attendance month2 = new Attendance(21, 4, 2);
        Attendance month3 = new Attendance(22, 1, 6);

        Attendance total = month1 + month2 + month3;

        System.Console.WriteLine("Total working days: " + total.WorkingDays);
        System.Console.WriteLine("Total leaves taken: " + total.LeavesTaken);
        System.Console.WriteLine("Total permission taken: " + total.PermissionTaken);

        System.Console.WriteLine("Total salary: " + total.WorkingDays * 500);
    }
}