using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Question2
{
    public class Calculator
    {
        public int Subject1 { get; set; }
        public int Subject2 { get; set; }
        public int Subject3 { get; set; }
        public int Subject4 { get; set; }
        public int Subject5 { get; set; }
        public int Subject6 { get; set; }

        public Calculator(int subject1, int subject2, int subject3, int subject4, int subject5, int subject6)
        {
            Subject1 = subject1;
            Subject2 = subject2;
            Subject3 = subject3;
            Subject4 = subject4;
            Subject5 = subject5;
            Subject6 = subject6;

        }

        public static Calculator operator +(Calculator semester1, Calculator semester2)
        {
            return new Calculator(semester1.Subject1 + semester2.Subject1, semester1.Subject2 + semester2.Subject2, semester1.Subject3 + semester2.Subject3, semester1.Subject4 + semester2.Subject4, semester1.Subject5 + semester2.Subject5, semester1.Subject6 + semester2.Subject6);
        }
    }
}