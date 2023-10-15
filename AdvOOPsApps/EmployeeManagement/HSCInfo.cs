using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement
{
    public class HSCInfo : PersonalInfo, ICalculate
    {
        /*
        HSC info class: inherit Personal info class, ICalculate
        Prop: School name, Board, marksheet num, Physics chemistry math, HSCtotal, HSCaverage marks
        Method: Calculate - total, average, ShowHSCDetails
        */

        public string SchoolDetails { get; set; }

        public string Board { get; set; }

        public string HSCMarksheetNumber { get; set; }

        public int Physics { get; set; }

        public int Chemistry { get; set; }

        public int Maths { get; set; }

        public int HSCTotalMarks { get; set; }

        public int HSCAverageMarks  { get; set; }

        public HSCInfo(string name, string fatherName, string mailID, long phone, string schoolDetails, string board, string hscMarksheetNumber, int physics, int chemistry, int maths) : base (name, fatherName, mailID, phone){

            SchoolDetails = schoolDetails;
            Board = board;
            HSCMarksheetNumber = hscMarksheetNumber;
            Physics = physics;
            Chemistry = chemistry;
            Maths = maths;
            Calculate();
        
        }

        public void Calculate(){
            HSCTotalMarks = Physics+Chemistry+Maths;
            HSCAverageMarks = HSCTotalMarks/3;
        }

        
        //Write in main
        // public void ShowHSCDetails(){

        // }
    }
}