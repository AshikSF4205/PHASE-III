using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement
{
    public class EmploymentExchange : UGInfo, IEligiblity
    {

        public string EmploymentID { get; set; }

        public DateTime DateOfRegistration { get; set; }

        public string OfficeID { get; set; }

        public EmploymentExchange(string name, string fatherName, string mailID, long phoneNumber, string schoolName, string board, string hscMarksheetNum, int physics, int chemistry, int maths, string employmentID, DateTime dateOfRegistration, string officeID, string collegeName, string universityName, string ugMarksheetnum, int mark1, int mark2, int mark3, int mark4) : base(name, fatherName, mailID, phoneNumber, schoolName, board, hscMarksheetNum, physics, chemistry, maths, collegeName, universityName, ugMarksheetnum, mark1, mark2, mark3, mark4)

        {

            EmploymentID = employmentID;

            DateOfRegistration = dateOfRegistration;

            OfficeID = officeID;

        }

        public bool Eligiblity(int hscCutOff, int ugCutOff)
        {
            if (HSCAverageMarks >= hscCutOff && UGAverageMarks >= ugCutOff)
            {
                return true;
            }
            return false;
        }

    }
}