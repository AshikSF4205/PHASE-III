namespace Interface
{
    public class Q2
    {
        
    }
    class StudentInfo{
        public StudentInfo(string studentID, string name, string fatherName, long mobile)
        {
            StudentID = studentID;
            Name = name;
            FatherName = fatherName;
            Mobile = mobile;
        }


        public string StudentID { get; set; }
        public string Name { get; set; }
        public string FatherName { get; set; }
        public long Mobile { get; set; }

        public void Display(){
            System.Console.WriteLine($"{Name} {FatherName} {StudentID} {Mobile}");
        }
    }
    class EmployeeInfo{
        public EmployeeInfo(string employeeID, string name, string fatherName)
        {
            EmployeeID = employeeID;
            Name = name;
            FatherName = fatherName;
        }


        public string EmployeeID { get; set; }
        public string Name { get; set; }
        public string FatherName { get; set; }
        public void Display(){
            System.Console.WriteLine($"{EmployeeID} {Name} {FatherName}");
        }
    }
}