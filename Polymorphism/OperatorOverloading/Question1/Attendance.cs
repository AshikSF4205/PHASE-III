using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Question1
{
    public class Attendance
    {
        public int WorkingDays { get; set; }
        public int LeavesTaken { get; set; }
        public int PermissionTaken { get; set; }

        public Attendance(int workingDays,int leavesTaken,int permissionTaken){
            WorkingDays = workingDays;
            LeavesTaken = leavesTaken;
            PermissionTaken = permissionTaken;
        }

        public static Attendance operator+(Attendance month1,Attendance month2)
        {
            return new Attendance(month1.WorkingDays + month2.WorkingDays,month1.LeavesTaken + month2.LeavesTaken,month1.PermissionTaken+month2.PermissionTaken);
        }
    }
}