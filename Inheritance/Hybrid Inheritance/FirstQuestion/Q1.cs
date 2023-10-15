namespace Hybrid
{
    public enum Gender{Male,Female};
    public class Q1
    {
        
    }

    class PersonalInfo{
        public PersonalInfo(string name, string fatherName, long phone, string mail, DateTime doB, Gender gender)
        {
            Name = name;
            FatherName = fatherName;
            Phone = phone;
            Mail = mail;
            DoB = doB;
            this.gender = gender;
        }


        public string Name  { get; set; }
        public string FatherName { get; set; }
        public long  Phone { get; set; }
        public string Mail { get; set; }
        public DateTime DoB { get; set; }
        public Gender gender { get; set; }
        
    }

    class TheoryExamMarks  : PersonalInfo {
        public TheoryExamMarks(string name, string fatherName, long phone, string mail, DateTime doB, Gender gender,int[] sem1, int[] sem2, int[] sem3, int[] sem4)
        : base (name,fatherName,phone,mail,doB,gender)
        {
            Sem1 = sem1;
            Sem2 = sem2;
            Sem3 = sem3;
            Sem4 = sem4;
        }


        public int[] Sem1 { get; set; }
        public int[] Sem2 { get; set; }
        public int[] Sem3 { get; set; }
        public int[] Sem4 { get; set; }                
    }

     class Marksheet:TheoryExamMarks,ICalculate{
        public Marksheet(string name, string fatherName, long phone, string mail, DateTime doB, Gender gender,int[] sem1, int[] sem2, int[] sem3, int[] sem4,string marksheetNumber, DateTime dateofIssue, double total, double percentage)
        : base(name,fatherName,phone,mail,doB,gender,sem1,sem2,sem3,sem4)
        {
            MarksheetNumber = marksheetNumber;
            DateofIssue = dateofIssue;
            Total = total;
            Percentage = percentage;
        }

            double TotalSem1 = 0;
            double TotalSem2 = 0;
            double TotalSem3 = 0;
            double TotalSem4 = 0;
        public void CalculateUG(){
            for(int i =0;i<6;i++){
                TotalSem1+=Sem1[i];
                TotalSem2+=Sem2[i];
                TotalSem3+=Sem3[i];
                TotalSem4+=Sem4[i];                
            }

           Total = TotalSem1+TotalSem2+TotalSem3+TotalSem4;
           Percentage = TotalSem1+TotalSem2+TotalSem3+TotalSem4 / 4;
        }
        public string MarksheetNumber { get; set; }
        public DateTime DateofIssue { get; set; }
        public double Total { get; set; }
        public double  Percentage { get; set; }
        public int ProjectMark { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }


        public void showUGMarksheet(){
             System.Console.WriteLine($"{TotalSem1} {TotalSem1} {TotalSem1} {TotalSem3}");
        }

    }
}
