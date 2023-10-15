namespace PartialClass
{
    public enum Gender{Default,Male,Female};
    public partial class EmployeeInfo 
    {
       
        public string EmployeeId { get; set; }
            public string  Name { get; set; }
            public DateTime DOB { get; set; }
            public long Mobile { get; set; }

            public Gender gender { get; set; }



    }
}