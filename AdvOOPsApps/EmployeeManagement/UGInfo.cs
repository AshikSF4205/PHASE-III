using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement
{
    public class UGInfo : HSCInfo, ICalculate
    {
        /*
        UG Info class: Inherit HSC Info, ICalculate
        Prop: College name, Univ name, marksheet num, sem mark1, mark2, mark 3, mark4, UGtotal, UGaverage
        Method: Calculate – total, average; ShowUGDetails
        */

        public string CollegeName { get; set; }
        public string UniversityName { get; set; }
        public string UGMarksheetNumber { get; set; }
        public int Mark1 { get; set; }
        public int Mark2 { get; set; }
        public int Mark3 { get; set; }
        public int Mark4 { get; set; }
        public int UGTotalMarks { get; set; }
        public int UGAverageMarks { get; set; }

        public UGInfo(string name, string fatherName, string mailID, long phone, string schoolDetails, string board, string hscMarksheetNumber, int physics, int chemistry, int maths, string collegeName, string universityName, string ugMarksheetNumber, int mark1, int mark2, int mark3, int mark4) : base(name, fatherName, mailID, phone, schoolDetails, board, hscMarksheetNumber, physics, chemistry, maths)
        {

            CollegeName = collegeName;
            UniversityName = universityName;
            UGMarksheetNumber = ugMarksheetNumber;
            Mark1 = mark1;
            Mark2 = mark2;
            Mark3 = mark3;
            Mark4 = mark4;
            Calculate();

        }

        public new void Calculate()
        {
            UGTotalMarks = Mark1 + Mark2 + Mark3 + Mark4;
            UGAverageMarks = UGTotalMarks / 3;
        }


        //write in main
        // public void ShowUGDetails()
        // {

        // }
    }
}