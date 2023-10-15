namespace PartialClass
{
    public partial class EmployeeInfo
    {
        public EmployeeInfo(){

        }
         public EmployeeInfo(string employeeId, string name, DateTime dOB, long mobile, Gender gender)
        {
            EmployeeId = employeeId;
            Name = name;
            DOB = dOB;
            Mobile = mobile;
            this.gender = gender;
        }

        
    }
}